using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Konwersja_szescienne
    {
        virtual public double ConvertTo1(string x) 
        { 
            double result = Convert.ToDouble(x);
            return result;
        }
    }

    public class Metry : Konwersja_szescienne
    {
        override public double ConvertTo1(string x)
        {
            double result = Convert.ToDouble(x);
            result *= 1000000;
            return result;
        }
    }

    public class Cale : Konwersja_szescienne
    {
        override public double ConvertTo1(string x)
        {
            double result = Convert.ToDouble(x);
            result *= 16.387;
            return result;
        }
    }

    public class Galony : Konwersja_szescienne
    {
        override public double ConvertTo1(string x)
        {
            double result = Convert.ToDouble(x);
            result *= 3785.142;
            return result;
        }
    }
}
