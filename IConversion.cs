using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    interface IConversion
    {
         string ConvertToString(double x);
         double ConvertToDouble(string x);
    }
}
