namespace InterfacesUndDelegates
{
  public static class Erweiterungsmethoden
  {
    public static void Ausgeben<T>(this IEnumerable<T> liste, string titel = "")
    {
      Console.WriteLine("********************************************");
      Console.WriteLine($"*** {titel} ***");

      foreach(T element in liste)
      {
        Console.WriteLine(element);
      }

      Console.WriteLine();
    }
  }
}
