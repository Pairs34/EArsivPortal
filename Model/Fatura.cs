using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EArsivPortal.Model
{
    public class Datum
    {
        [DisplayName("Belge Numarası")]
        public string belgeNumarasi { get; set; }
        [DisplayName("Satıcı VKN/TCKN")]
        public string saticiVknTckn { get; set; }
        [DisplayName("Satıcı Unvan/Ad Soyad")]
        public string saticiUnvanAdSoyad { get; set; }
        [DisplayName("Belge Tarihi")]
        public string belgeTarihi { get; set; }
        [DisplayName("Belge Türü")]
        public string belgeTuru { get; set; }
        [DisplayName("Onay Durumu")]
        public string onayDurumu { get; set; }
        [DisplayName("ETTN")]
        public string ettn { get; set; }
        [DisplayName("İptal / İtiraz")]
        public string iptalItiraz { get; set; }
        [DisplayName("Talep Durumu")]
        public string talepDurum { get; set; }
    }

    public class Metadata
    {
        public string optime { get; set; }
    }

    public class Fatura
    {
        public List<Datum> data { get; set; }
        public Metadata metadata { get; set; }
    }
}
