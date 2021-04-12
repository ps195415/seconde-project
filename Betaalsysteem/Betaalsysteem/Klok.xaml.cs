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
using System.Windows.Threading;
namespace Betaalsysteem
{
    /// <summary>
    /// Interaction logic for Klok.xaml
    /// </summary>
    public partial class Klok : Window
    {
        double _seconde = 0;
        double _minuut = 0;
        double _uur = 0;
        DispatcherTimer _myTimer = new DispatcherTimer();
        public Klok()
        {
            InitializeComponent();
            configurateMyTimer();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_myTimer.IsEnabled)
            {
                _myTimer.Stop();

                tbSec.IsEnabled = true;
                tbMinuut.IsEnabled = true;
                tbUur.IsEnabled = true;
                btStart.Content = "start de tijd";
                return;
            }
            _myTimer.Start();

            tbSec.IsEnabled = false;
            tbMinuut.IsEnabled = false;
            tbUur.IsEnabled = false;

            btStart.Content = "(re)set time ";

        }
        private void configurateMyTimer()
        {
            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;

        }





        private void _myTimer_Tick(object sender, EventArgs e)
        {
            _seconde = double.Parse(tbSec.Text);
            _minuut = double.Parse(tbMinuut.Text);
            _uur = double.Parse(tbMinuut.Text);
            try
            {
                tbSec.Text = ((Int32.Parse(tbSec.Text)) + 1).ToString("00");
                _myTimer.Start();
                if (_seconde > 59)
                {
                    tbSec.Text = "00";
                    tbMinuut.Text = ((Int32.Parse(tbMinuut.Text)) + 1).ToString("00");
                    if (_minuut > 58)
                    {
                        tbMinuut.Text = "00";
                        tbUur.Text = ((Int32.Parse(tbUur.Text)) + 1).ToString("00");
                        if (_uur > 23)
                        {
                            tbUur.Text = "00";
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }






        private void tbSec_GotFocus(object sender, RoutedEventArgs e)
        {
            tbSec.Text = "";
        }

        private void tbMinuut_GotFocus(object sender, RoutedEventArgs e)
        {
            tbMinuut.Text = "";
        }

        private void tbUur_GotFocus(object sender, RoutedEventArgs e)
        {
            tbUur.Text = "";
        }

        private void tbSec_LostFocus(object sender, RoutedEventArgs e)
        {

            try
            {
                _seconde = double.Parse(tbSec.Text);
                if (_seconde < 10)
                {
                    tbSec.Text = _seconde.ToString("00");
                }
                else if (_seconde > 60)
                {
                    MessageBox.Show("Voer a.u.b een getal onder de 60 in");
                    tbSec.Text = "60";

                }
            }
            catch (Exception)
            {
                return;
            }
        }


        private void tbMinuut_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                _minuut = double.Parse(tbMinuut.Text);
                if (_minuut < 10)
                {
                    tbMinuut.Text = _minuut.ToString("00");
                }
                else if (_minuut > 60)
                {
                    MessageBox.Show("Voer a.u.b een getal onder de 60 in");
                    tbMinuut.Text = "60";

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void tbUur_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                _uur = double.Parse(tbUur.Text);
                if (_uur < 10)
                {
                    tbUur.Text = _seconde.ToString("00");
                }
                else if (_uur > 24)
                {
                    MessageBox.Show("Voer a.u.b een getal onder de 24 in");
                    tbUur.Text = "24";

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void tbSec_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tbSec.Text, "[^0-9]"))
                {
                    tbSec.Text = "60";
                    MessageBox.Show("voer a.u.b een getal in");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tbMinuut_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tbMinuut.Text, "[^0-9]"))
                {
                    MessageBox.Show("Voer alsjeblieft alleen cijfers in");
                    tbMinuut.Text = tbSec.Text.Remove(tbMinuut.Text.Length - 1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tbUur_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbUur.Text, "[^0-9]"))
            {
                MessageBox.Show("Voer alsjeblieft alleen cijfers in");
                tbUur.Text = tbSec.Text.Remove(tbUur.Text.Length - 1);
            }
        }

        private void betaalsysteem_click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Hide();
        }
    }
}
