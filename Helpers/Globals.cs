using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Syncfusion.XlsIO;

namespace EArsivPortal.Helpers
{
    public static class Globals
    {
        public static void WaitForPageLoad(this IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
                WebDriverWait webDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
                webDriverWait.Until<bool>((IWebDriver wd) => javaScriptExecutor
                    .ExecuteScript("return document.readyState")
                    .Equals("complete"));
            }
            catch (Exception)
            {
            }
        }
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
        public static void KillAllDrivers()
        {
            new[] { "geckodriver", "chromedriver", "operadriver" }.ForEach((x) =>
            {
                foreach (var process in Process.GetProcessesByName(x))
                {
                    try
                    {
                        process.Kill();
                    }
                    catch (Exception)
                    {
                    }
                }
            });
        }
        public static string ToQueryString(this NameValueCollection nameValueCollection)
        {
            NameValueCollection httpValueCollection = HttpUtility.ParseQueryString(String.Empty, Encoding.UTF8);
            httpValueCollection.Add(nameValueCollection);
            return httpValueCollection.ToString();
        }

        public static Dictionary<DateTime,DateTime> GunlereBol(DateTime StartDateTime,DateTime EndDateTime, int gunSayisi = 8)
        {
            Dictionary<DateTime, DateTime> parcaliGunler = new Dictionary<DateTime, DateTime>();

            DateTime startTime = StartDateTime;

            DateTime breakTime = StartDateTime.Date.AddDays(gunSayisi);
            if (breakTime < StartDateTime)
            {
                breakTime = breakTime.AddDays(gunSayisi);
            }

            while (breakTime < EndDateTime)
            {
                parcaliGunler.Add(startTime, breakTime);
                startTime = breakTime;
                breakTime = breakTime.AddDays(gunSayisi);

            }
            parcaliGunler.Add(startTime, EndDateTime);


            return parcaliGunler;
        }
        public static void ViewAsExcel<T>(List<T> coupons, string fileName = "temp.xlsx")
        {
            try
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "faturalar.xlsx";

                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet sheet = workbook.Worksheets[0];

                    sheet.ImportData(coupons.AsEnumerable(), 1, 1, true);

                    IListObject table = sheet.ListObjects.Create("Faturalar", sheet.UsedRange);

                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium13;

                    sheet.UsedRange.AutofitColumns();

                    Stream excelStream = File.Create(filePath);
                    workbook.SaveAs(excelStream);
                    excelStream.Dispose();

                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(filePath)
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            WorkingDirectory = Path.GetDirectoryName(filePath) ?? string.Empty,
                            UseShellExecute = true
                        }
                    };

                    process.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static IWebElement IsElementPresent(this IWebDriver driver, By by, int timeout = 25)
        {
            IWebElement Founded = null;

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout))
                {
                    PollingInterval = TimeSpan.FromSeconds(5),
                    Message = "Zaman aşımı"
                };

                wait.IgnoreExceptionTypes
                (
                    typeof(ElementNotVisibleException),
                    typeof(NoSuchElementException),
                    typeof(StaleElementReferenceException)
                );

                IWebElement element = wait.Until(x => driver.FindElement(@by));
                if (element.Displayed)
                {
                    Founded = element;
                }
                else
                {
                    Founded = null;
                }
            }
            catch (Exception)
            {
            }

            return Founded;
        }
    }
}
