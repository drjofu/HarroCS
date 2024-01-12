namespace VerberbungBeispiel
{
  public class A
  {
    public A(string info)
    {
      Console.WriteLine("ctor A");

      // Vorsicht: hier NIE virtuelle Methoden aufrufen!!!
      //TuWasVirtuelles();
    }

    public void TuWas()
    {
      Console.WriteLine("Tut was: A");
    }

    public virtual void TuWasVirtuelles()
    {
      Console.WriteLine("was virtuelles in A");
    }
  }

  public class B : A
  {
    public B(string info) : base(info)
    {
      Console.WriteLine("ctor B");
    }

    // verdecken, shadowing
    public new void TuWas()
    {
      Console.WriteLine("Tut was: B");
      Console.WriteLine($"aus Basisklasse: ");
      base.TuWas();
    }

    public override void TuWasVirtuelles()
    {
      Console.WriteLine("was virtuelles in B");
    }
  }
}
