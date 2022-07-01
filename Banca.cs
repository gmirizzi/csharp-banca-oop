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
            Console.Write("Inserisci il nome ");
            string name = Console.ReadLine();
            Console.Write("Inserisci il cognome ");
            string surname = Console.ReadLine();
            Console.Write("Inserisci il codice fiscale ");
            string cf = Console.ReadLine();
            Cliente newClient = new Cliente(name, surname, cf);
            clientList.Add(newClient);
            Console.WriteLine("Cliente aggiunto");
        }

        public static void EditClient()
        {
            Console.WriteLine("Inserisci il codice fiscale del cliente ");
            string cf = Console.ReadLine();
            Cliente client = Banca.SearchClient(cf);
            Console.Write("Inserisci nuovo nome ");
            string nameEdited = Console.ReadLine();
            client.FirstName = nameEdited;
            Console.Write("Inserisci nuovo cognome ");
            string surnameEdited = Console.ReadLine();
            client.Surname = surnameEdited;
            Console.Write("Inserisci nuovo codice fiscale ");
            string cfEdited = Console.ReadLine();
            client.CodiceFiscale = cfEdited;
            Console.WriteLine("Cliente aggiunto");
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

        public static List<Prestito> SearchClientLoans(string cf)
        {
            List<Prestito> listaPrestiti = new List<Prestito>();
            foreach (Prestito prestito in Banca.loanList)
            {
                if (prestito.Intestatario.CodiceFiscale == cf)
                    listaPrestiti.Add(prestito);
            }
            return listaPrestiti;
        }

        public static int GetLoansAmount(string cf)
        {
            int amount = 0;
            List<Prestito> listaPrestiti = Banca.SearchClientLoans(cf);
            foreach (Prestito item in listaPrestiti)
            {
                amount += item.Ammontare;
            }
            return amount;
        }

        //public static int GetRateRimanenti(string cf)
        //{

        //}
    }
}
