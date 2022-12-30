using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using Syncfusion.XlsIO.FormatParser.FormatTokens;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace EArsivPortal
{
    public partial class frmMain : Form
    {
        private IWebDriver driver;
        private List<Datum> aktarilan_faturalar;
        private IVDFatura ivd_faturalar;

        private string earsiv_fatura_json_path =
            AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "earsivfatura.json";
        private string ivd_json_path =
            AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "ivdfatura.json";
        public frmMain()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("NTg0NTgxQDMxMzkyZTM0MmUzMGJKb1N5dlp5bGhXS2VvNzREUFhZWURHdmp1Mm55Wm12YUVRSEcySWc2b1U9");
            new DriverManager().SetUpDriver(new ChromeConfig());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(earsiv_fatura_json_path))
            {
                var fatura_json = File.ReadAllText(earsiv_fatura_json_path);
                aktarilan_faturalar = JsonConvert.DeserializeObject<Fatura>(fatura_json).data;
                portalGrid.DataSource = aktarilan_faturalar;
            }

            dtIvdEndDate.Value = DateTime.Now.GetLastDayOfMonth();
            dtEndEarsiv.Value = DateTime.Now.GetLastDayOfMonth();
        }

        private void btnGetDataIVD_Click(object sender, EventArgs e)
        {
            try
            {
                var parsedUrl = HttpUtility.ParseQueryString(txtIVDUrl.Text.Replace("https://ivd.gib.gov.tr/tvd_side/index.jsp?", ""));
                List<Faturasonuc> faturaSonuc = new List<Faturasonuc>();
                var token = parsedUrl.Get("token");
                var tarihFarki = dtIvdEndDate.Value.Subtract(dtIvdStartDate.Value).TotalDays;
                if (tarihFarki >= 8)
                {
                    var parcaliGunler = Globals.GunlereBol(dtIvdStartDate.Value, dtIvdEndDate.Value, 7);

                    foreach (var gun in parcaliGunler)
                    {
                        var faturaResult = GetIVDData(token, gun.Key.ToString("yyyy-MM-dd"), gun.Value.ToString("yyyy-MM-dd"));
                        faturaSonuc.AddRange(faturaResult);
                    }
                }
                else if (tarihFarki <= 8)
                {
                    var faturaResult = GetIVDData(token, dtIvdStartDate.Text, dtIvdEndDate.Text);
                    faturaSonuc.AddRange(faturaResult);
                }

                dataResultIVD.DataSource = faturaSonuc;

                File.WriteAllText(ivd_json_path, JsonConvert.SerializeObject(faturaSonuc));

                MessageBox.Show("Tarama tamamlandı");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private List<Faturasonuc> GetIVDData(string token, string startDate, string endDate)
        {
            var jp = new JObject();
            jp.Add("faturaTarihBas", startDate);
            jp.Add("faturaTarihSon", endDate);
            jp.Add("textBox", "");

            var queryParams = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryParams.Add("cmd", "EFaturaIslemleri_eFaturaGoruntuleSorgula");
            queryParams.Add("pageName", "P_EFATURA");
            queryParams.Add("token", token);
            queryParams.Add("jp", JsonConvert.SerializeObject(jp));

            var client = new RestClient("https://ivd.gib.gov.tr/tvd_server/dispatch");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json, text/javascript, */*; q=0.01");
            request.AddHeader("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("Origin", "https://ivd.gib.gov.tr");
            request.AddHeader("Referer", txtIVDUrl.Text);
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
            request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", queryParams.ToString(), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                ivd_faturalar = JsonConvert.DeserializeObject<IVDFatura>(response.Content);
                return ivd_faturalar.Data.Faturasonuc;
            }
            else
            {
                return new List<Faturasonuc>();
            }
        }

        private void btnGetEArsivData_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(dtStartEarsiv.Text))
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
                date_request["baslangic"] = dtStartEarsiv.Text;
                date_request["hourlySearchInterval"] = "NONE";
                date_request["bitis"] = String.IsNullOrWhiteSpace(dtEndEarsiv.Text) == true
                    ? dtStartEarsiv.Text
                    : dtEndEarsiv.Text;
                var body =
                    $@"cmd=EARSIV_PORTAL_ADIMA_KESILEN_BELGELERI_GETIR&pageName=RG_ALICI_TASLAKLAR&token={token}&jp={HttpUtility.UrlEncode(date_request.ToString())}";
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body,
                    ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Fatura content = JsonConvert.DeserializeObject<Fatura>(response.Content);
                    aktarilan_faturalar = content.data;
                    File.WriteAllText(earsiv_fatura_json_path, response.Content);
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

                MessageBox.Show("Fatura Aktarımları Tamamlandı");
            }
        }

        private void btnExportEArsivData_Click(object sender, EventArgs e)
        {
            Globals.ViewAsExcel(aktarilan_faturalar);
        }

        private void btnExportIVD_Click(object sender, EventArgs e)
        {
            Globals.ViewAsExcel(ivd_faturalar.Data.Faturasonuc);
        }

        private void checkNonExistInvoice_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(earsiv_fatura_json_path) && !File.Exists(ivd_json_path))
            {
                MessageBox.Show("Faturalar oluşturulmamış , lütfen önce faturaları her iki sitedende çekiniz.");
                return;
            }

            var earsivFaturalar = File.ReadAllText(earsiv_fatura_json_path);
            var ivdFaturalar = File.ReadAllText(ivd_json_path);

            var earsivObject = JsonConvert.DeserializeObject<Fatura>(earsivFaturalar);//Datum
            var ivdObject = JsonConvert.DeserializeObject<List<Faturasonuc>>(ivdFaturalar);

            List<EksikFatura> eksikFaturalar = new List<EksikFatura>();

            foreach (var earsivFatura in earsivObject.data)
            {
                var isExist = ivdObject.FirstOrDefault(x => x.FaturaNo == earsivFatura.belgeNumarasi && x.MukVkn == earsivFatura.saticiVknTckn);
                if (isExist == null)
                {
                    eksikFaturalar.Add(new EksikFatura
                    {
                        FaturaNo = earsivFatura.belgeNumarasi,
                        FirmaAdı = earsivFatura.saticiUnvanAdSoyad,
                        FaturaTarihi = earsivFatura.belgeTarihi,
                        IptalItiraz = earsivFatura.iptalItiraz,
                        OnayDurumu = earsivFatura.onayDurumu,
                        TalepDurumu = earsivFatura.talepDurum,
                        VKNTCK = earsivFatura.saticiVknTckn
                    });
                }
            }

            MessageBox.Show($"Eksik Fatura Kontrolü Tamamlandı.Earşiv Sayısı = {earsivObject.data.Count} , IVDSayısı = {ivdObject.Count} {eksikFaturalar.Count} adet fatura eksik.");

            if (eksikFaturalar.Count > 0)
            {
                Globals.ViewAsExcel(eksikFaturalar, "eksikfaturalar.xlsx");
            }
        }

        private void tabMain_TabIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
