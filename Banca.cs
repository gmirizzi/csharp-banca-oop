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
            Console.WriteLine("Inserisci il codice fiscale del cliente ");
            string cf = Console.ReadLine();
            Cliente client = Banca.SearchClient(cf);
            Console.WriteLine("Inserisci l'ammontare del prestito ");
            int ammontare = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'ammontare della rata ");
            int rata = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la data di inizio ");
            DateTime inizio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la data di fine ");
            DateTime fine = DateTime.Parse(Console.ReadLine());
            Prestito newLoan = new Prestito(client, ammontare, rata, inizio, fine);
            loanList.Add(newLoan);
            Console.WriteLine("Prestito aggiunto");
        }

        //public static List<Prestito> SearchClientLoans(string cf)
        //{

        //}

        //public static int GetLoansAmount(string cf)
        //{

        //}

        //public static int GetRateRimanenti(string cf)
        //{

        //}
    }
}
