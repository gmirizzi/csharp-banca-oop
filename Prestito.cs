using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Prestito
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

        public virtual string Riepilogo()
        {
            return $"Intestario: {this.Intestatario.FirstName} {this.Intestatario.Surname}\n" +
                $"Somma: {this.Ammontare}\n" +
                $"Importo rata: {this.Rata}\n" +
                $"Data inizio: {this.Inizio}\n" +
                $"Data fine: {this.Fine}";
        }

    }
    public class PrestitoATassoFisso : Prestito, IPrestito
    {
        public PrestitoATassoFisso(Cliente intestatario, int ammontare, int rata, DateTime inizio, DateTime fine, int tassoInteresse) : base(intestatario, ammontare, rata, inizio, fine)
        {
            TassoInteresse = tassoInteresse;
        }

        public int TassoInteresse { get; set; }
        public int CalcoloInteressi()
        {
            int durataPrestitoAnni = this.Fine.Subtract(this.Inizio).Days / 365;
            return this.Ammontare * this.TassoInteresse / 100 * durataPrestitoAnni;
        }
        public override string Riepilogo()
        {
            return $"Intestario: {this.Intestatario.FirstName} {this.Intestatario.Surname}\n" +
                $"Somma: {this.Ammontare + CalcoloInteressi()}\n" +
                $"Importo rata: {this.Rata}\n" +
                $"Data inizio: {this.Inizio}\n" +
                $"Data fine: {this.Fine}";
        }
    }
}

