using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_tacueo
{
    public class Infok
    {
        //KonyvID,Szerzo,Cim,KiadasEve,Oldalszam

        public int KonyvID { get; set; } 

        public string Szerzo { get; set; } = string.Empty;

        public string Cim { get; set; } = string.Empty;

        public int KiadasEve { get; set; }

        public int Oldalszam { get; set; }
    }
}
