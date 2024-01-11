using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Längenmaß
  {
    private double längeInMeter;

    public double LängeInMeter
    {
      get { return längeInMeter; }
      set { längeInMeter = value; }
    }

    public double LängeInMillimeter
    {
      get { return längeInMeter * 1000; }
      set { längeInMeter = value / 1000; }
    }

    public double LängeInZoll
    {
      get { return LängeInMillimeter / 25.4; }
      set { LängeInMillimeter = value * 25.4; }
    }
  }
}
