using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
   public class Square
    {
        public double Squ(string x)
        {
            double result;
            result = Convert.ToDouble(x);
            result *= result;
            return result;
        }
    }
}
