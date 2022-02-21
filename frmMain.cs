using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using EArsivPortal.Helpers;
using EArsivPortal.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;
using Syncfusion.Licensing;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace EArsivPortal
{
    public partial class frmMain : Form
    {
        private IWebDriver driver;
        private List<Datum> aktarilan_faturalar;

        private string fatura_json_path =
            AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "fatura.json";
        public frmMain()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("NTg0NTgxQDMxMzkyZTM0MmUzMGJKb1N5dlp5bGhXS2VvNzREUFhZWURHdmp1Mm55Wm12YUVRSEcySWc2b1U9");
            new DriverManager().SetUpDriver(new ChromeConfig());
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtStartDate.Text))
                {
                    MessageBox.Show("Başlangıç tarihi boş olamaz.");
                    return;
                }

                ChromeOptions driverOption = new ChromeOptions();
                driverOption.AddArgument("--headless");

                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;

                driver = new ChromeDriver(driverService, driverOption);
                driver.Url = "https://earsivportal.efatura.gov.tr/intragiris.html";
                driver.WaitForPageLoad();

                var username = driver.IsElementPresent(By.XPath("//input[@id='userid']"), 5);
                var password = driver.IsElementPresent(By.XPath("//input[@id='password']"), 5);
                var loginbtn = driver.IsElementPresent(By.XPath("//button[@name='action']"), 5);

                username.SendKeys(txtUserName.Text);
                password.SendKeys(txtPassword.Text);

                loginbtn.Click();


                driver.WaitForPageLoad();

                Thread.Sleep(TimeSpan.FromSeconds(2));

                var exist_url = new Uri(driver.Url);

                string token = HttpUtility.ParseQueryString(exist_url.Query).Get("token");

                if (String.IsNullOrWhiteSpace(token))
                {
                    MessageBox.Show("Token okunamadı");
                    return;
                }

                var client = new RestClient("https://earsivportal.efatura.gov.tr/earsiv-services/dispatch");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Connection", "keep-alive");
                request.AddHeader("Accept", "application/json, text/javascript, */*; q=0.01");
                client.UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.102 Safari/537.36";
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                request.AddHeader("Sec-GPC", "1");
                request.AddHeader("Origin", "https://earsivportal.efatura.gov.tr");
                request.AddHeader("Sec-Fetch-Site", "same-origin");
                request.AddHeader("Sec-Fetch-Mode", "cors");
                request.AddHeader("Sec-Fetch-Dest", "empty");
                request.AddHeader("Referer",
                    $"https://earsivportal.efatura.gov.tr/index.jsp?token={token}&v=1645275913735");
                request.AddHeader("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                var date_request = new JObject();
                date_request["baslangic"] = txtStartDate.Text;
                date_request["bitis"] = String.IsNullOrWhiteSpace(txtEndDate.Text) == true
                    ? txtStartDate.Text
                    : txtEndDate.Text;
                var body =
                    $@"cmd=EARSIV_PORTAL_ADIMA_KESILEN_BELGELERI_GETIR&pageName=RG_ALICI_TASLAKLAR&token={token}&jp={HttpUtility.UrlEncode(date_request.ToString())}";
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body,
                    ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Fatura content = JsonConvert.DeserializeObject<Fatura>(response.Content);
                    aktarilan_faturalar = content.data;
                    File.WriteAllText(fatura_json_path, response.Content);
                    Globals.ViewAsExcel(content.data);
                    portalGrid.DataSource = content.data;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var fatura_json = File.ReadAllText(fatura_json_path);
            aktarilan_faturalar = JsonConvert.DeserializeObject<Fatura>(fatura_json).data;
            portalGrid.DataSource = aktarilan_faturalar;
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            Globals.ViewAsExcel(aktarilan_faturalar);
        }
    }
}
