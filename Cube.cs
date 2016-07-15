using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
   class Cube : Square
    {
       public double Cub(string y)
       {
           return Squ(y) * Convert.ToDouble(y);
       }
    }
}
