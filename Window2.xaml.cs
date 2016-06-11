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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void kasowanie_Click_1(object sender, RoutedEventArgs e)
        {
            wyswietlacz1.Text = "";
            wyswietlacz2.Text = "";
            wyswietlacz3.Text = "";
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_szescienne k = new Metry();
                wyswietlacz2.Text = k.ConvertTo1(wyswietlacz1.Text).ToString();
            }
            catch
            {
                wyswietlacz2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_szescienne k = new Cale();
                wyswietlacz2.Text = Convert.ToString(k.ConvertTo1(wyswietlacz1.Text));
            }
            catch
            {
                wyswietlacz2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_szescienne k = new Galony();
                wyswietlacz2.Text = Convert.ToString(k.ConvertTo1(wyswietlacz1.Text));
            }
            catch
            {
                wyswietlacz2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_kwadratowe k = new Konwersja_kwadratowe();
                wyswietlacz3.Text = k.ConvertTo2(k.Hektary(wyswietlacz1.Text));
            }
            catch
            {
                wyswietlacz3.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_kwadratowe k = new Konwersja_kwadratowe();
                wyswietlacz3.Text = k.ConvertTo2(k.Akry(wyswietlacz1.Text));
            }
            catch
            {
                wyswietlacz3.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            try
            {
                Konwersja_kwadratowe k = new Konwersja_kwadratowe();
                wyswietlacz3.Text = k.ConvertTo2(k.Jardy(wyswietlacz1.Text));
            }
            catch
            {
                wyswietlacz3.Text = "Syntax Error";
            }
        }
    }
}
