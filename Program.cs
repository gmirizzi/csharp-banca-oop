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
DateTime date3 = new DateTime(2010, 1, 1, 8, 0, 15);
DateTime date4 = new DateTime(2024, 8, 18, 13, 30, 30);
Prestito prestitoFake2 = new Prestito(cliente1, 13000, 200, date3, date4);
Banca.loanList.Add(prestitoFake2);
Console.WriteLine(prestitoFake.Riepilogo());
Console.WriteLine();
Console.WriteLine($"{prestitoFake.Intestatario.FirstName} deve pagare ancora {Banca.GetRateRimanenti(cliente1.CodiceFiscale)} rate");
Console.WriteLine();
//Stampa riepilogo
Banca.Riepilogo();
Console.WriteLine();
//Nuovo conto
Conto newConto = new ContoRisparmio(cliente1);
newConto.Saldo = 1000;
newConto.Preleva(50);
newConto.Preleva(50);
//Modifica cliente
Banca.EditClient();
//Ricerca cliente
Console.Write("Inserisci codice fiscale");
string cf = Console.ReadLine();
Console.WriteLine(Banca.SearchClient(cf).Riepilogo());
//Aggiunta cliente da input
Banca.AddClient();