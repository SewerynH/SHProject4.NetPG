using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Reciprocal
    {
        public double Rec(string x)
        {
            double result;
            result = Convert.ToDouble(x);
            result = 1 / result;
            return result;
        }
    }
}
