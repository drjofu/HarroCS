//using io= System.IO;
using ConsoleApp1;
using System.Collections.Generic;
using System.IO;
//using System;

int i = 10;
Console.WriteLine(i / 3);
Console.WriteLine(i % 3);
Console.WriteLine(11 % 3);
Console.WriteLine(12 % 3);

int zahl = 124;
if (zahl % 2 == 0)
  Console.WriteLine("gerade");
else
  Console.WriteLine("ungerade");

double x = (double)10 / 3;
Console.WriteLine(x);

int t = 10;
t++;
t += 10;
Console.WriteLine(t);

t = 10;
t += t++ + ++t;  // so besser nicht...
Console.WriteLine(t);

foreach (char c in "Hallo Welt")
{
  Console.WriteLine(c);
}

List<int> zahlen = new List<int>() { 1, 32, 64, 346, 7 };
Console.WriteLine("**********************");
foreach (int z in zahlen)
{
  Console.WriteLine(z);
}

Console.WriteLine("zur Info: t hat den Wert {0}, zahl: {1}", t, zahl);
Console.WriteLine("**********************");
Console.WriteLine();

TuWas("C# lernen", 20);

TuWas();
TuWas("JS vergessen");
TuWas(wieLange: 60);
TuWas(wieLange: 30, wasDenn: "C# verstehen");

Console.WriteLine("**********************");

string text = "1000";
//int dieZahl = int.Parse(text);
//Console.WriteLine($"Zahl hat den Wert: {dieZahl}");
//int dieZahl;
if (int.TryParse(text, out int dieZahl))
  Console.WriteLine($"gültige Zahl: {dieZahl}");
else
  Console.WriteLine($"der Text {text} ist keine gültige Zahl");

Console.WriteLine($"1+2= {1 + 2}, 3*4={3 * 4}");
Console.WriteLine("1+2= {1 + 2}");

Console.WriteLine("1+2=" + (1+2));

double z1 = 123.456;
Console.WriteLine($"z hat den Wert {z1:0.0}");

string t1 = "Hallo schöne neue";
string t2 = "Welt";

Console.WriteLine($"{t1,-10} {t2}");

//io.File.Delete("x.abc");
File.Delete("x.abc");

Console.WriteLine("*****************************");
Console.WriteLine();

Längenmaß lm = new Längenmaß();
lm.LängeInMeter = 10;
Console.WriteLine(lm.LängeInMillimeter);
Console.WriteLine(lm.LängeInZoll);

lm.LängeInZoll = 100;
Console.WriteLine(lm.LängeInMillimeter);
Console.WriteLine(lm.LängeInMeter);

//Konto k = new Konto(123, "ich");
Konto k = Konto.KontoAnlegen(123, "ich");

Console.ReadLine();

static void TuWas(string wasDenn = "nix", int wieLange = 10)
{
  Console.WriteLine("Tut was: {0}, {1} Minuten lang", wasDenn, wieLange);
}