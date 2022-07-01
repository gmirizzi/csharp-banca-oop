using csharp_banca_oop;
//Aggiunta cliente
Cliente cliente1 = new Cliente("Giuseppe", "Mirizzi", "asdf1234");
Banca.clientList.Add(cliente1);
Console.WriteLine(cliente1.Riepilogo());
Console.WriteLine();
//Creazione prestito
DateTime date0 = new DateTime(2010, 1, 1, 8, 0, 15);
DateTime date2 = new DateTime(2023, 8, 18, 13, 30, 30);
Prestito prestitoFake = new Prestito(cliente1, 10000, 100, date0, date2);
Banca.loanList.Add(prestitoFake);
Console.WriteLine(prestitoFake.Riepilogo());
Console.WriteLine();
Console.WriteLine($"{prestitoFake.Intestatario.FirstName} deve pagare ancora {Banca.GetRateRimanenti(cliente1.CodiceFiscale)} rate");
Console.WriteLine();
//Stampa riepilogo
Banca.Riepilogo();
Console.WriteLine();
//Cazzate con le date
DateTime date1 = new DateTime(2023, 6, 3, 22, 15, 0);
Console.WriteLine(date1);
Console.WriteLine(DateTime.Today);
Console.WriteLine(date1.Subtract(DateTime.Today).Days/30);

//Modifica cliente
Banca.EditClient();

//Ricerca cliente
Console.Write("Inserisci codice fiscale");
string cf = Console.ReadLine();
Console.WriteLine(Banca.SearchClient(cf).Riepilogo());

//Aggiunta cliente da input
Banca.AddClient();
