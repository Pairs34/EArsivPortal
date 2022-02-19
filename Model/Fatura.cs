using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EArsivPortal.Model
{
    public class Datum
    {
        public string belgeNumarasi { get; set; }
        public string saticiVknTckn { get; set; }
        public string saticiUnvanAdSoyad { get; set; }
        public string belgeTarihi { get; set; }
        public string belgeTuru { get; set; }
        public string onayDurumu { get; set; }
        public string ettn { get; set; }
        public string iptalItiraz { get; set; }
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
