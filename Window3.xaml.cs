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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {


            try
            {
                Point point2 = new Circle(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text), Convert.ToDouble(radius.Text));
                display.Text = point2.SurfaceArea(); //polymorphism
                if (Convert.ToDouble(radius.Text) <= 0)
                {
                    display.Text = "promien musi byc liczba dodatnia!!!";
                }
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Circle circle2 = new Sphere(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text), Convert.ToDouble(radius.Text));
                display.Text = circle2.SurfaceArea(); //polymorphism
                if (Convert.ToDouble(radius.Text) <= 0)
                {
                    display.Text = "promien musi byc liczba dodatnia!!!";
                }
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Sphere sphere2 = new Roller(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text), Convert.ToDouble(radius.Text), Convert.ToDouble(height.Text));
                display.Text = sphere2.SurfaceArea(); //polymorphism
                if (Convert.ToDouble(radius.Text) <= 0 || Convert.ToDouble(height.Text) <= 0)
                {
                    display.Text = "promien i wysokosc musza byc liczbami dodatnimi!!!";
                }
            }
            catch
            {
                display.Text = "Syntax Error";
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            height.Text = "";
            radius.Text = "";
            a.Text = "";
            b.Text = "";
            display.Text = "";
        }
    }
}
