// See https://aka.ms/new-console-template for more information
using InterfacesUndDelegates;
//using System.Linq;

Console.WriteLine("Hello world!");

List<Konto> konten = new List<Konto>
{
  new Konto { Kontonummer = 1, Inhaber = "Dagobert", Saldo = 999999999999 },
  new Konto { Kontonummer = 45, Inhaber = "Donald", Saldo = -4566 },
  new Konto { Kontonummer = 101, Inhaber = "Tick", Saldo = 100.5 },
  new Konto { Kontonummer = 104, Inhaber = "Trick", Saldo = 100.2 },
  new Konto { Kontonummer = 103, Inhaber = "Track", Saldo = 100.7 },
  new Konto { Kontonummer = 33, Inhaber = "Micky", Saldo = 34735 },
  new Konto { Kontonummer = 888, Inhaber = "Panzerknacker", Saldo = -45757 }
};

//Konto k = new Konto();
//k.Kontonummer = 2;
//k.Inhaber = "asdg";
//k.Saldo = 234;
//konten.Add(k);

//foreach (Konto konto in konten)
//{
//  Console.WriteLine(konto);
//}

Erweiterungsmethoden.Ausgeben(konten, "ursprüngliche Liste");
konten.Ausgeben("als Erweiterungsmethode");

konten.Sort();
konten.Ausgeben("nach Sortierung");

Comparison<Konto> vergleichsmethode = new Comparison<Konto>(VergleicheNachSaldo);
konten.Sort(vergleichsmethode);
konten.Ausgeben("nach Sortierung via Delegate");

konten.Sort(VergleicheNachSaldo);
konten.Ausgeben("vereinfachte Syntax");

// anonyme Methode (C# 2.0)
konten.Sort(delegate (Konto k1, Konto k2)
{
  return k1.Inhaber.CompareTo(k2.Inhaber);
});
konten.Ausgeben("via anonymer Methode");

// Lambda-Ausdruck (C# 3.0) (das gleiche wie zuvor, nur andere Syntax)
konten.Sort((k1, k2) =>                      // goes to
{
  return k1.Saldo.CompareTo(k2.Saldo);
});

konten.Ausgeben("via Lambda");

konten.Sort((k1, k2) => k1.Saldo.CompareTo(k2.Saldo));
konten.Ausgeben("dito, etwas kürzer");

Konto kontoDagobert = konten.Find(k => k.Inhaber == "Dagobert");
if (kontoDagobert == null)
  Console.WriteLine("nix gefunden");
else
  Console.WriteLine($"gefunden: {kontoDagobert.Kontonummer}");

konten.FindAll(k => k.Saldo > 0).Ausgeben("Saldo > 0");

var erg = konten
  .Where(k => k.Saldo > 0)
  .OrderByDescending(k => k.Saldo)
  .Select(k => new {  k.Inhaber, Zinsen= k.Saldo * 0.03 })
  .ToList();

erg.Ausgeben("via Linq-Erweiterungsmethoden");
erg.Ausgeben("via Linq-Erweiterungsmethoden");

//kontoDagobert = konten
//                  .Where(k => k.Inhaber == "Dagobert")
//                  .First();

kontoDagobert = konten.FirstOrDefault(k => k.Inhaber == "Dagobert");


Console.WriteLine($"gefunden: {kontoDagobert?.ToString() ?? "nichts"}");




//Console.WriteLine(erg.GetType().Name);
//konten.Ausgeben();

//var i = 123;
//var t = "hallo";
//var x = new { A = 99, B = "Hallo" };
//Console.WriteLine(x);
//Console.WriteLine(x.A);
//Console.WriteLine(x.B);
//Console.WriteLine(x.GetType().Name);
////x.A = 12;

Console.ReadLine();


int VergleicheNachSaldo(Konto k1, Konto k2)
{
  return k1.Saldo.CompareTo(k2.Saldo);
}