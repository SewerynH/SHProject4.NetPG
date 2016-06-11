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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private async void pokaz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("x.txt"))
                {
                    String line = await sr.ReadToEndAsync();
                    wyswietl.Text = line;
                }
            }
            catch (Exception ex)
            {
                wyswietl.Text = "Could't read the file";
            }
         }
    }
}
