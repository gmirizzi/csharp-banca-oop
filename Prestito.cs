using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Prestito
    {
        Cliente intestatario;
        int Ammontare { get; set; }
        int Rata { get; set; }
        DateTime Inizio { get; set; }
        DateTime Fine { get; set; }

        public string Riepilogo ()
        {
            return "";
        }
    }
}
