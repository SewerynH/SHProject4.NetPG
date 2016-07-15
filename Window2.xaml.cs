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

        private void delete_Click_1(object sender, RoutedEventArgs e)
        {
            display1.Text = "";
            display2.Text = "";
            display3.Text = "";
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                CubeConversion cubeconversion1 = new CubeConversion();
                display2.Text = cubeconversion1.ConvertToString(cubeconversion1.Meters(display1.Text));
            }
            catch
            {
                display2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            try
            {
                CubeConversion cubeconversion1 = new CubeConversion();
                display2.Text = cubeconversion1.ConvertToString(cubeconversion1.Inch(display1.Text));
            }
            catch
            {
                display2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            try
            {
                CubeConversion cubeconversion1 = new CubeConversion();
                display2.Text = cubeconversion1.ConvertToString(cubeconversion1.Gallon(display1.Text));
            }
            catch
            {
                display2.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            try
            {
                SquareConversion squareconversion1 = new SquareConversion();
                display3.Text = squareconversion1.ConvertToString(squareconversion1.Hectare(display1.Text));
            }
            catch
            {
                display3.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            try
            {
                SquareConversion squareconversion1 = new SquareConversion();
                display3.Text = squareconversion1.ConvertToString(squareconversion1.Acre(display1.Text));
            }
            catch
            {
                display3.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            try
            {
                SquareConversion squareconversion1 = new SquareConversion();
                display3.Text = squareconversion1.ConvertToString(squareconversion1.Yard(display1.Text));
            }
            catch
            {
                display3.Text = "Syntax Error";
            }
        }
    }
}
