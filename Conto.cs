using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Conto
    {
        public Conto(Cliente intestatario)
        {
            Intestatario = intestatario;
        }
        public Cliente Intestatario { get; }
        public decimal Saldo { get; set; }
    }
}
