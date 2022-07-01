using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Prestito
    {
        public Prestito(Cliente intestatario, int ammontare, int rata, DateTime inizio, DateTime fine)
        {
            Intestatario = intestatario;
            Ammontare = ammontare;
            Rata = rata;
            Inizio = inizio;
            Fine = fine;
        }

        public Cliente Intestatario { get; set; }
        public int Ammontare { get; set; }
        public int Rata { get; set; }
        public DateTime Inizio { get; set; }
        public DateTime Fine { get; set; }

        public string Riepilogo ()
        {
            return "";
        }
    }
}
