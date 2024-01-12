namespace VerberbungBeispiel
{
  public abstract class Haustier
  {
    public abstract void Fressen();
  }

  public class Katze : Haustier
  {
    public override void Fressen()
    {
      Console.WriteLine("die Katze frisst die Maus");
    }
  }

  public class Tiger : Katze
  {
    public override void Fressen()
    {
      Console.WriteLine("Tiger frisst Hase"); ;
    }
  }

  public abstract class Hund : Haustier
  {

  }

  public class Dalmatiner : Hund
  {
    public override void Fressen()
    {
      Console.WriteLine("Dalmatiner frisst gepunktete Leberwurst");
    }
  }
}

public static class Dingsbums { }

