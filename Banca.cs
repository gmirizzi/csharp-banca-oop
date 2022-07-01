using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        public static string name;
        public static List<Prestito> loanList = new List<Prestito> ();
        public static List<Cliente> clientList = new List<Cliente>();

        public static void AddClient (Cliente cliente)
        {   

            clientList.Add(cliente);
        }
    }
}
