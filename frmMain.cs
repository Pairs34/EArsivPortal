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
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using Downloader;
using EArsivPortal.Helpers;
using EArsivPortal.Model;
using EArsivPortal.Model.AlisFatura;
using EArsivPortal.Model.SatisFatura;
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
        private List<Model.AlisFatura.Datum> aktarilan_alis_faturalari;
        private List<Model.SatisFatura.Datum> aktarilan_satis_faturalari;
        private List<Faturasonuc> ivd_faturalar = new List<Faturasonuc>();

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
                aktarilan_satis_faturalari = JsonConvert.DeserializeObject<SatisFatura>(fatura_json).data;
                portalGrid.DataSource = aktarilan_satis_faturalari;
            }

            dtIvdEndDate.Value = DateTime.Now.GetLastDayOfMonth();
            dtEndEarsiv.Value = DateTime.Now.GetLastDayOfMonth();
        }

        private void btnGetDataIVD_Click(object sender, EventArgs e)
        {
            try
            {
                ivd_faturalar.Clear();
                var parsedUrl = HttpUtility.ParseQueryString(txtIVDUrl.Text.Replace("https://ivd.gib.gov.tr/tvd_side/index.jsp?", ""));
                var token = parsedUrl.Get("token");
                var tarihFarki = dtIvdEndDate.Value.Subtract(dtIvdStartDate.Value).TotalDays;
                if (tarihFarki >= 8)
                {
                    var parcaliGunler = Globals.GunlereBol(dtIvdStartDate.Value, dtIvdEndDate.Value, 7);

                    foreach (var gun in parcaliGunler)
                    {
                        var faturaResult = GetIVDData(token, gun.Key.ToString("yyyy-MM-dd"), gun.Value.ToString("yyyy-MM-dd"));
                        ivd_faturalar.AddRange(faturaResult);
                    }
                }
                else if (tarihFarki <= 8)
                {
                    var faturaResult = GetIVDData(token, dtIvdStartDate.Value.ToString("yyyy-MM-dd"), dtIvdEndDate.Value.ToString("yyyy-MM-dd"));
                    ivd_faturalar.AddRange(faturaResult);
                }

                dataResultIVD.DataSource = ivd_faturalar;

                File.WriteAllText(ivd_json_path, JsonConvert.SerializeObject(ivd_faturalar));

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
                var faturaresponse = JsonConvert.DeserializeObject<IVDFatura>(response.Content);
                return faturaresponse.Data.Faturasonuc;
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
                    $"https://earsivportal.efatura.gov.tr/index.jsp?token={txtEarsivToken.Text}");
                request.AddHeader("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");

                var body = String.Empty;
                if (cbInvoiceType.SelectedIndex == 0)
                {
                    var date_request = new JObject();
                    date_request["baslangic"] = dtStartEarsiv.Text;
                    date_request["hourlySearchInterval"] = "NONE";
                    date_request["bitis"] = String.IsNullOrWhiteSpace(dtEndEarsiv.Text) == true
                        ? dtStartEarsiv.Text
                        : dtEndEarsiv.Text;
                    body = $@"cmd=EARSIV_PORTAL_ADIMA_KESILEN_BELGELERI_GETIR&pageName=RG_ALICI_TASLAKLAR&token={txtEarsivToken.Text}&jp={HttpUtility.UrlEncode(date_request.ToString())}";
                }
                else
                {
                    var date_request = new JObject();
                    date_request["hangiTip"] = "5000/30000";
                    date_request["baslangic"] = dtStartEarsiv.Text;
                    date_request["bitis"] = String.IsNullOrWhiteSpace(dtEndEarsiv.Text) == true
                        ? dtStartEarsiv.Text
                        : dtEndEarsiv.Text;
                    body = $@"cmd=EARSIV_PORTAL_TASLAKLARI_GETIR&pageName=RG_BASITTASLAKLAR&token={txtEarsivToken.Text}&jp={HttpUtility.UrlEncode(date_request.ToString())}";
                }
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body,
                    ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if(cbInvoiceType.SelectedIndex == 0)
                    {
                        var content = JsonConvert.DeserializeObject<SatisFatura>(response.Content);
                        aktarilan_satis_faturalari = content.data;
                        File.WriteAllText(earsiv_fatura_json_path, response.Content);

                        if (content.data.Count > 0)
                        {
                            Globals.ViewAsExcel(content.data);
                        }
                        portalGrid.DataSource = content.data;
                    }
                    else
                    {
                        var content = JsonConvert.DeserializeObject<AlisFatura>(response.Content);
                        aktarilan_alis_faturalari = content.data;
                        File.WriteAllText(earsiv_fatura_json_path, response.Content);

                        if (content.data.Count > 0)
                        {
                            Globals.ViewAsExcel(content.data);
                        }
                        portalGrid.DataSource = content.data;
                    }
                    
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
            if(cbInvoiceType.SelectedIndex == 0)
            {
                Globals.ViewAsExcel(aktarilan_alis_faturalari);
            }
            else
            {
                Globals.ViewAsExcel(aktarilan_satis_faturalari);
            }
            
        }

        private void btnExportIVD_Click(object sender, EventArgs e)
        {
            Globals.ViewAsExcel(ivd_faturalar);
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

            var earsivObject = JsonConvert.DeserializeObject<SatisFatura>(earsivFaturalar);//Datum
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

        private void btnBynGetFiles_Click(object sender, EventArgs e)
        {
            try
            {
                var token = GetBtnLoginToken(txtBynUsername.Text, txtBynParola.Text, txtBynSifre.Text);

                var bynQueryResult = QueryByn(dtBynStartDate.Value, dtBynEndDate.Value, token);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(bynQueryResult);
                var thkNodes = doc.DocumentNode.SelectNodes("//td[contains(@id,'thkPDF')]");
                var bynNodes = doc.DocumentNode.SelectNodes("//td[contains(@id,'bynPDF')]");

                var tahakkuklar = thkNodes.Select(x => x.Id).ToList();
                var beyannameler = bynNodes.Select(x => x.Id).ToList();


                List<string> downloadErrorOidsByn = new List<string>();
                List<string> downloadErrorOidsThk = new List<string>();
                DialogResult selectedFolder = folderSelector.ShowDialog();
                if (selectedFolder == DialogResult.OK && !String.IsNullOrEmpty(folderSelector.SelectedPath))
                {
                    foreach (var byn in beyannameler)
                    {
                        var bynDownUrl = "https://ebeyanname.gib.gov.tr/dispatch?";

                        var queryParams = System.Web.HttpUtility.ParseQueryString(string.Empty);
                        queryParams.Add("cmd", "IMAJ");
                        queryParams.Add("subcmd", "BEYANNAMEGORUNTULE");
                        queryParams.Add("TOKEN", token);
                        queryParams.Add("beyannameOid", byn.Replace("bynPDF", ""));
                        queryParams.Add("inline", "true");

                        bynDownUrl += queryParams.ToString();

                        try
                        {
                            HttpClient client = new HttpClient();
                            var response = client.GetAsync(new Uri(bynDownUrl));
                            response.Wait();
                            using (var fs = new FileStream(Path.Combine(folderSelector.SelectedPath, $"{byn}byn.pdf"), FileMode.CreateNew))
                            {
                                response.Result.Content.CopyToAsync(fs).Wait();
                            }
                        }
                        catch (Exception err)
                        {
                            downloadErrorOidsByn.Add(byn);
                        }
                    }

                    foreach (var thk in tahakkuklar)
                    {
                        var thkDownUrl = "https://ebeyanname.gib.gov.tr/dispatch?";

                        var queryParams = System.Web.HttpUtility.ParseQueryString(string.Empty);
                        queryParams.Add("cmd", "IMAJ");
                        queryParams.Add("subcmd", "BEYANNAMEGORUNTULE");
                        queryParams.Add("TOKEN", token);
                        queryParams.Add("beyannameOid", thk.Replace("thkPDF", ""));
                        queryParams.Add("tahakkukOid", thk.Replace("thkPDF", ""));
                        queryParams.Add("inline", "true");

                        thkDownUrl += queryParams.ToString();

                        try
                        {
                            HttpClient client = new HttpClient();
                            var response = client.GetAsync(new Uri(thkDownUrl));
                            response.Wait();
                            using (var fs = new FileStream(Path.Combine(folderSelector.SelectedPath, $"{thk}thk.pdf"), FileMode.CreateNew))
                            {
                                response.Result.Content.CopyToAsync(fs).Wait();
                            }
                        }
                        catch (Exception err)
                        {
                            downloadErrorOidsByn.Add(thk);
                        }
                    }
                }

                MessageBox.Show($"Dosyaların indirilmesi tamamlandı , İndirilemeyen BYN = {downloadErrorOidsByn.Count} , İndirilemeyen THK = {downloadErrorOidsThk.Count}");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private string GetBtnLoginToken(string username, string password, string sifre)
        {
            try
            {
                var client = new RestClient("https://ebeyanname.gib.gov.tr/eyeks");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0";
                request.AddHeader("Accept", "*/*");
                request.AddHeader("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
                request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                request.AddHeader("X-Requested-With", "XMLHttpRequest");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                request.AddHeader("Origin", "https://ebeyanname.gib.gov.tr");
                request.AddHeader("DNT", "1");
                request.AddHeader("Connection", "keep-alive");
                request.AddHeader("Referer", "https://ebeyanname.gib.gov.tr/giris.html");
                request.AddHeader("Sec-Fetch-Dest", "empty");
                request.AddHeader("Sec-Fetch-Mode", "cors");
                request.AddHeader("Sec-Fetch-Site", "same-origin");
                var body = $@"username={username}&password2={password}&password1={sifre}&eyekscommand=ajaxlogin&redirectionpath=context1";
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content;

                    XElement element = XElement.Parse(content);
                    var ajaxlogin = element.Elements().FirstOrDefault(x => x.Name.LocalName == "TOKEN");
                    return ajaxlogin.Value;
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private string QueryByn(DateTime baslangicDate, DateTime bitisDate, string token)
        {
            try
            {
                var baslangicTarih = baslangicDate.AddMonths(1).ToString("yyyyMMdd");
                var bitisTarih = bitisDate.AddMonths(1).ToString("yyyyMMdd");

                var queryParams = System.Web.HttpUtility.ParseQueryString(string.Empty);
                queryParams.Add("cmd", "BEYANNAMELISTESI");
                queryParams.Add("sorguTipiP", "1");
                queryParams.Add("donemBasYil", baslangicDate.ToString("yyyy"));
                queryParams.Add("donemBasAy", baslangicDate.ToString("MM"));
                queryParams.Add("donemBitYil", bitisDate.ToString("yyyy"));
                queryParams.Add("donemBitAy", bitisDate.ToString("MM"));
                queryParams.Add("sorguTipiZ", "1");
                queryParams.Add("bitisTarihi", bitisTarih);
                queryParams.Add("baslangicTarihi", baslangicTarih);
                queryParams.Add("sorguTipiD", "1");
                queryParams.Add("durum", "2");
                queryParams.Add("TOKEN", token);

                var client = new RestClient("https://ebeyanname.gib.gov.tr/dispatch");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0";
                request.AddHeader("Accept", "*/*");
                request.AddHeader("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
                request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                request.AddHeader("X-Requested-With", "XMLHttpRequest");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                request.AddHeader("Origin", "https://ebeyanname.gib.gov.tr");
                request.AddHeader("Connection", "keep-alive");
                request.AddHeader("Referer", $"https://ebeyanname.gib.gov.tr/dispatch?cmd=LOGIN&TOKEN={token}&CHANGEPWD=TRUE");
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", queryParams.ToString(), ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        private async void btnDownloadInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                var downloadOpt = new DownloadConfiguration()
                {
                    ChunkCount = 8, // file parts to download, default value is 1
                    ParallelDownload = true // download parts of file as parallel or not. Default value is false
                };

                var downloader = new DownloadService(downloadOpt);

                var dialog = folderSelector.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    var loadedInvoice = (portalGrid.DataSource) as List<Model.SatisFatura.Datum>;

                    foreach (var datum in loadedInvoice)
                    {
                        string downloadFileUri = $"https://earsivportal.efatura.gov.tr/earsiv-services/download?token={txtEarsivToken.Text}&ettn={datum.ettn}&belgeTip=FATURA&onayDurumu=Onaylandı&cmd=EARSIV_PORTAL_BELGE_INDIR";

                        await downloader.DownloadFileTaskAsync(downloadFileUri, $"{folderSelector.SelectedPath}\\{datum.ettn}.zip");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            MessageBox.Show("İndirme tamamlandı");
        }
    }
}
