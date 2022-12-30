using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EArsivPortal.Model
{
    internal class EksikFatura
    {
        public string FirmaAdı { get; set; }
        public string FaturaNo { get; set; }
        public string VKNTCK { get; set; }
        public string OnayDurumu { get; set; }
        public string IptalItiraz { get; set; }
        public string TalepDurumu { get; set; }
        public string FaturaTarihi { get; set; }
    }
}
