using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok_2025_01_07
{
    internal class Jarmuadat
    {
        public string Típus { get; set; }
        public int Év { get; set; }
        public string Utas { get; set; }
        public string Személyzet { get; set; }
        public int Utazósebbeség { get; set; }
        public int Felszállótömeg { get; set; }
        public string Fesztáv { get; set; }


        public Jarmuadat(string sor)
        {
            string[] s = sor.Split(';');
            Típus = s[0];
            Év = int.Parse(s[1]);
            Utas = s[2];
            Személyzet = s[3];
            Utazósebbeség = int.Parse(s[4]);
            Felszállótömeg = int.Parse(s[5]);
            Fesztáv = s[6];
        }
    }
}
