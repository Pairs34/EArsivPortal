using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EArsivPortal.Model.AlisFatura
{
    public class Datum
    {
        public string belgeNumarasi { get; set; }
        public string aliciVknTckn { get; set; }
        public string aliciUnvanAdSoyad { get; set; }
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

    public class AlisFatura
    {
        public List<Datum> data { get; set; }
        public Metadata metadata { get; set; }
    }
}
