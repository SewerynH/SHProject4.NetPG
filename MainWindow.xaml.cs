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

        Square square1 = new Square();
        Element element1 = new Element();
        Reciprocal reciprocal1 = new Reciprocal();
        Cube cube1 = new Cube();

        private static int MAX_BASE = 36;
        private static String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        List<string> LatestResults = new List<string>();

         private enum Types : int
        {
            Binary = 2,
            Trinary,
            Octal = 8,
            Hexadecimal = 16,
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

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ".";
        }

        private void naught_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void two_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void three_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void bracketR_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ")";
        }

        private void bracketL_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "(";
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "+";
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "-";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "/";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "*";
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            display2.Text = "";
        }

        private void square_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                display2.Text = display.Text + "*" + display.Text;
                display.Text = square1.Squ(display.Text).ToString();
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void score_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;
            try
            {
                var res = obj.Eval(display.Text);
                str = Convert.ToString(res);
                display2.Text = display.Text;
                display.Text = str;

                LatestResults.Add(display.Text);
                File.WriteAllLines(@"x.txt", LatestResults);
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void element_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                display2.Text = "sqrt(" + display.Text + ")";
                display.Text = element1.Sqrt(display.Text).ToString();
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void reciprocal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                display2.Text = "reciproc(" + display.Text + ")";
                display.Text = reciprocal1.Rec(display.Text).ToString();
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void cube_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                display2.Text = display.Text + "*" + display.Text + "*" + display.Text;
                display.Text = cube1.Cub(display.Text).ToString();
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void hex_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(display.Text);
                int something = (int)Types.Hexadecimal;
                display.Text = convertTo(x, something);
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void oct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(display.Text);
                int something = (int)Types.Octal;
                display.Text = convertTo(x, something);
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void tri_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(display.Text);
                int something = (int)Types.Trinary;
                display.Text = convertTo(x, something);
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void bin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(display.Text);
                int something = (int)Types.Binary;
                display.Text = convertTo(x, something);
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
             Window1 wnd = new Window1();
             wnd.Show();
        }

        private void konwenter_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd = new Window2();
            wnd.Show();
        }

        private void area_Click(object sender, RoutedEventArgs e)
        {
            Window3 wnd = new Window3();
            wnd.Show();
        }
    }
}
