using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Conto : IConto
    {
        public Conto(Cliente intestatario)
        {
            Intestatario = intestatario;
        }
        public Cliente Intestatario { get; }
        public decimal Saldo { get; set; }

        public virtual void Deposita(int somma)
        {
            this.Saldo += somma;
        }

        public virtual void Preleva(int somma)
        {
            if (this.Saldo > 0 & somma <= this.Saldo)
                this.Saldo -= somma;
        }
    }

    public class ContoRisparmio : Conto
    {
        public ContoRisparmio(Cliente intestatario) : base(intestatario)
        {
        }
        public override void Deposita(int somma)
        {
            if (somma <= 5000)
                base.Saldo += somma;
        }

        public override void Preleva(int somma)
        {   
            if (base.Saldo >= 1000 && somma >= 50)
            {
                base.Saldo -= somma;
            }
            else if (base.Saldo >= 1000 && somma > 1000)
            {
                base.Saldo -= somma;
            }

        }

    }
}
