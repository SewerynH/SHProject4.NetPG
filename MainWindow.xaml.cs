using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
        }

        Potegowanie potegowanie1 = new Potegowanie();
        Pierwiastek pierwiastek1 = new Pierwiastek();
        Odwrotnosc odwrotnosc1 = new Odwrotnosc();
        Szescian szescian1 = new Szescian();

        private static int MAX_BASE = 36;
        private static String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        List<string> ostatnie_wyniki = new List<string>();

         private enum Rodzaj : int
        {
            Binarny=2,
            Trojkowy,
            Osemkowy=8,
            Szesnastkowy=16,
        }

        private static String convertTo(int n, int newBase)
        {
            String result = "";
            if (n == 0)
                return "0";
            while (n > 0)
            {
                result = pattern[n % newBase] + result;
                n /= newBase;
            }
            return result;
        }

        private void kropka_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += ".";
        }

        private void zero_Click_1(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "0";
        }

        private void jeden_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "1";
        }

        private void dwa_Click_1(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "2";
        }

        private void trzy_Click_1(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "3";
        }

        private void cztery_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "4";
        }

        private void piec_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "5";
        }

        private void szesc_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "6";
        }

        private void siedem_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "7";
        }

        private void osiem_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "8";
        }

        private void dziewiec_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "9";
        }

        private void nawiasp_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += ")";
        }

        private void nawiasl_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "(";
        }

        private void dodawanie_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "+";
        }

        private void odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "-";
        }

        private void dzielenie_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "/";
        }

        private void mnozenie_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text += "*";
        }

        private void kasowanie_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz.Text = "";
            wyswietlacz2.Text = "";
        }

        private void kwadrat_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz2.Text = wyswietlacz.Text + "*" + wyswietlacz.Text;
            wyswietlacz.Text = potegowanie1.pot(wyswietlacz.Text).ToString();
        }

        private void wynik_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;
            try
            {
                var res = obj.Eval(wyswietlacz.Text);
                str = Convert.ToString(res);
                wyswietlacz2.Text = wyswietlacz.Text;
                wyswietlacz.Text = str;

                ostatnie_wyniki.Add(wyswietlacz.Text);
                File.WriteAllLines(@"x.txt", ostatnie_wyniki);
            }
            catch
            {
                wyswietlacz.Text = "Syntax Error";
            }
        }

        private void pierwiastek_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz2.Text = "sqrt(" + wyswietlacz.Text + ")";
            wyswietlacz.Text = pierwiastek1.pierw(wyswietlacz.Text).ToString();
        }

        private void odwrotnosc_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz2.Text = "reciproc(" + wyswietlacz.Text + ")";
            wyswietlacz.Text = odwrotnosc1.odwr(wyswietlacz.Text).ToString();
        }

        private void szescian_Click(object sender, RoutedEventArgs e)
        {
            wyswietlacz2.Text = wyswietlacz.Text + "*" + wyswietlacz.Text + "*" + wyswietlacz.Text;
            wyswietlacz.Text = szescian1.szes(wyswietlacz.Text).ToString();
        }

        private void hex_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(wyswietlacz.Text);
                int something = (int)Rodzaj.Szesnastkowy;
                wyswietlacz.Text = convertTo(x, something);
            }
            catch
            {
                wyswietlacz.Text = "Syntax Error";
            }
        }

        private void oct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(wyswietlacz.Text);
                int something = (int)Rodzaj.Osemkowy;
                wyswietlacz.Text = convertTo(x, something);
            }
            catch
            {
                wyswietlacz.Text = "Syntax Error";
            }
        }

        private void tri_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(wyswietlacz.Text);
                int something = (int)Rodzaj.Trojkowy;
                wyswietlacz.Text = convertTo(x, something);
            }
            catch
            {
                wyswietlacz.Text = "Syntax Error";
            }
        }

        private void bin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(wyswietlacz.Text);
                int something = (int)Rodzaj.Binarny;
                wyswietlacz.Text = convertTo(x, something);
            }
            catch
            {
                wyswietlacz.Text = "Syntax Error";
            }
        }

        private void lista_Click(object sender, RoutedEventArgs e)
        {
             Window1 wnd = new Window1();
             wnd.Show();
        }

        private void konwenter_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd = new Window2();
            wnd.Show();
        }

    }
}
