using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Cliente
    {
        public Cliente(string firstName, string surname, string codiceFiscale)
        {
            FirstName = firstName;
            Surname = surname;
            CodiceFiscale = codiceFiscale;
        }

        public string FirstName { get; set; }
        public string Surname { get; set; }

        public string CodiceFiscale { get; set; }

        public int Stipendio { get; set; }
    }
}
