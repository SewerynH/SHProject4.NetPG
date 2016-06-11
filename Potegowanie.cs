using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
   public class Potegowanie
    {
        public double pot(string x)
        {
            double result;
            result = Convert.ToDouble(x);
            result *= result;
            return result;
        }
    }
}
