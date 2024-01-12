
using VerberbungBeispiel;

B b = new B("zur Info");
A a = b;

a.TuWas();
b.TuWas();

a.TuWasVirtuelles();
b.TuWasVirtuelles();


Haustier ht1 = new Katze();
ht1.Fressen();

Haustier ht2 = new Dalmatiner();
ht2.Fressen();

Haustier ht3 = new Tiger();
ht3.Fressen();

string text = "Hallo Welt";
text = text.ToUpper();
Console.WriteLine(text);

text = "Hallo \nWelt";
Console.WriteLine(text);

text = @"c:\rauf\nirgendwo";
Console.WriteLine(text);

text = @"Hallo
    Zeile 1
    Zeile 2";
Console.WriteLine(text);

Console.ReadLine();