using csharp_banca_oop;
//Aggiunta cliente
Cliente cliente1 = new Cliente("Giuseppe", "Mirizzi", "asdf1234");
Banca.clientList.Add(cliente1);

Console.WriteLine(cliente1.Riepilogo());

//Creazione prestito
DateTime date0 = new DateTime(2010, 1, 1, 8, 0, 15);
DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
Prestito prestitoFake = new Prestito(cliente1, 10000, 100, date0, date2);
Console.WriteLine(prestitoFake.Riepilogo());

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
