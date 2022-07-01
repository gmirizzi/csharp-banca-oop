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
        public static List<Prestito> loanList = new List<Prestito>();
        public static List<Cliente> clientList = new List<Cliente>();

        public static void AddClient()
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

        public static void EditClient()
        {

        }

        public static Cliente SearchClient(string cf)
        {
            Cliente temp = null;
            foreach (Cliente cliente in clientList)
            {
                if (cliente.CodiceFiscale == cf)
                    temp = cliente;
            }
            return temp;
        }

        public static void AddLoan()
        {

        }

        public static List<Prestito> SearchClientLoans(string cf)
        {

        }

        public static int GetLoansAmount(string cf)
        {

        }

        public static int GetRateRimanenti(string cf)
        {

        }
    }
}
