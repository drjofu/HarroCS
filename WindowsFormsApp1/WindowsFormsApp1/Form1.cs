using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      // e.Graphics.DrawEllipse(Pens.Black, 10, 10, 100, 100);
      //Pen stift = new Pen(Color.Red, 5);
      //try
      //{
      //  e.Graphics.DrawEllipse(stift, 10, 10, 100, 100);
      //}
      //finally
      //{
      //  stift.Dispose();
      //}

      //     using Pen stift = new Pen(Color.Red, 5) ; // ab C# 8.0
      using (Pen stift = new Pen(Color.Red, 5))
      {
        e.Graphics.DrawEllipse(stift, 10, 10, 100, 100);
      }
    }
  }
}
