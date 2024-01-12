using System.Globalization;

DateTime jetzt= DateTime.Now;

//CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");

Console.WriteLine(jetzt);
Console.WriteLine($"{jetzt:d}");
Console.WriteLine($"{jetzt:D}");
Console.WriteLine($"{jetzt:t}");
Console.WriteLine($"{jetzt:T}");
Console.WriteLine($"{jetzt:g}");
Console.WriteLine($"{jetzt:G}");

Console.WriteLine(jetzt.ToUniversalTime().ToUniversalTime());

DateTime t = new DateTime(1920, 7, 14);
Console.WriteLine(t);

TimeSpan delta = jetzt - t;

Console.WriteLine(delta.TotalMinutes);

Console.WriteLine(jetzt.AddDays(10));
TimeSpan ts = TimeSpan.FromDays(10);

Console.WriteLine(jetzt + ts);



Console.ReadLine();