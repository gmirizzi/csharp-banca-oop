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

        public static void AddClient ()
        {
            Console.WriteLine("Inserisci il nome ");
            string name = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome ");
            string surname = Console.ReadLine();
            Console.WriteLine("Inserisci il codice fiscale ");
            string cf = Console.ReadLine();
            Cliente newClient = new Cliente(name, surname, cf);
            clientList.Add(newClient);
            Console.WriteLine("Cliente aggiunto");
        }
    }
}
