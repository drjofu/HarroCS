using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Konto
  {
    private int kontonummer;
    private string inhaber;

    //public Konto()
    //{

    //}

    private Konto(int kontonummer, string inhaber)
    {
      //if(inhaber=="Ganove")...
      this.kontonummer = kontonummer;
      this.inhaber = inhaber;
    }

    public static Konto KontoAnlegen(int kontonummer, string inhaber)
    {
      if (inhaber == "Ganove")
        return null;

      return new Konto(kontonummer, inhaber);
    }
  }
}
