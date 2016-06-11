using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
   class Szescian : Potegowanie
    {
       public double szes(string y)
       {
           return pot(y) * Convert.ToDouble(y);
       }
    }
}
