using csharp_banca_oop;
//Aggiunta cliente
Cliente cliente1 = new Cliente("Giuseppe", "Mirizzi", "asdf1234");
Banca.clientList.Add(cliente1);

//Ricerca cliente
Console.Write("Inserisci codice fiscale");
string cf = Console.ReadLine();
Console.WriteLine(Banca.SearchClient(cf).Riepilogo());

//Aggiunta cliente da input
Banca.AddClient();
