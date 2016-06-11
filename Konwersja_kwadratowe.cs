using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Konwersja_kwadratowe : IKonwersja
    {
         public string ConvertTo2(double x)
         {
             string y = Convert.ToString(x);
             return y;
         }
         public double Hektary(string z)
         {
             double x = Convert.ToDouble(z);
             return x*10000;
         }
         public double Akry(string z)
         {
             double x = Convert.ToDouble(z);
             return x * 4046.856;
         }
         public double Jardy(string z)
         {
             double x = Convert.ToDouble(z);
             return x * 0.836;
         }
    }
}
