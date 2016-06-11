using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Pierwiastek
    {
        public double pierw(string x)
        {
            double result;
            result = Convert.ToDouble(x);
            result = Math.Sqrt(result);
            return result;
        }
    }
}
