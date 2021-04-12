using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Betaalsysteem
{
    /// <summary>
    /// Interaction logic for Rekenmachine.xaml
    /// </summary>
    public partial class Rekenmachine : Window
    {
        public Rekenmachine()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                tb.Text = "Error!";
            }
        }

        private void result()
        {
            String Reken;
            int Getal = 0;
            if (tb.Text.Contains("+"))
            {
                Getal = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                Getal = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                Getal = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                Getal = tb.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            Reken = tb.Text.Substring(Getal, 1);
            double Getal1 = Convert.ToDouble(tb.Text.Substring(0, Getal));
            double Getal2 = Convert.ToDouble(tb.Text.Substring(Getal + 1, tb.Text.Length - Getal - 1));

            if (Reken == "+")
            {
                tb.Text += "=" + (Getal1 + Getal2);
            }
            else if (Reken == "-")
            {
                tb.Text += "=" + (Getal1 - Getal2);
            }
            else if (Reken == "*")
            {
                tb.Text += "=" + (Getal1 * Getal2);
            }
            else
            {
                tb.Text += "=" + (Getal1 / Getal2);
            }
        }

        private void Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Hide();
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }
    }
}
