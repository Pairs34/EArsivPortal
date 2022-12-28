using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EArsivPortal.Model
{
    public partial class IVDFatura
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("metadata")]
        public IVDMetadata Metadata { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("FATURASONUC")]
        public List<Faturasonuc> Faturasonuc { get; set; }
    }

    public partial class Faturasonuc
    {
        [JsonProperty("faturaNo")]
        public string FaturaNo { get; set; }

        [JsonProperty("toplam")]
        public string Toplam { get; set; }

        [JsonProperty("mukVkn")]
        public string MukVkn { get; set; }

        [JsonProperty("tarih")]
        public DateTimeOffset Tarih { get; set; }

        [JsonProperty("paraBirimi")]
        public string ParaBirimi { get; set; }

        [JsonProperty("tesisatNo")]
        public string TesisatNo { get; set; }

        [JsonProperty("zaman")]
        public DateTimeOffset Zaman { get; set; }

        [JsonProperty("odenecek")]
        public string Odenecek { get; set; }

        [JsonProperty("vergi")]
        public string Vergi { get; set; }

        [JsonProperty("unvan")]
        public string Unvan { get; set; }

        [JsonProperty("gonderimSekli")]
        public string GonderimSekli { get; set; }
    }

    public partial class IVDMetadata
    {
        [JsonProperty("optime")]
        public string Optime { get; set; }
    }
}
