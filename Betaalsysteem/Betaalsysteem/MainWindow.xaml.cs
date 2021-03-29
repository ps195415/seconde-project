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
using System.Windows.Threading;

namespace Betaalsysteem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


       
        double _AantalGeld = 0;
        double _Handmatig = 0;

        //geld
        double _5Cent = 0.05;
        double _10Cent = 0.10;
        double _20Cent = 0.20;
        double _50Cent = 0.5;
        double _1Euro = 1.00;
        double _2Euro = 2.00;
        double _5Euro = 5.00;
        double _10Euro = 10.00;
        double _20Euro = 20.00;
        double _50Euro = 50.00;
        double _100Euro = 100.00;
        double _200Euro = 200.00;


        double _dagen = 0;

 
        double totaal = 0;
        double KrijgtTerug = 0;
        double _Totaalbedrag = 0;
     

        double _cmbTotaalbedrag = 0.00;
        double _cmbTotaalbedrag1 = 0.00;
        double _cmbTotaalbedrag2 = 0.00;

        public MainWindow()
        {
            //idle timer, dit sluit de aplicatie af
            InitializeComponent();



            InitializeComponent();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(60) };
            timer.Tick += delegate
            {
                timer.Stop();
                this.Close();
                timer.Start();
            };
            timer.Start();
            InputManager.Current.PostProcessInput += delegate (object s, ProcessInputEventArgs r)
            {
                if (r.StagingItem.Input is MouseButtonEventArgs || r.StagingItem.Input is KeyEventArgs)
                    timer.Interval = TimeSpan.FromSeconds(60);
            };
        }











        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _dagen = double.Parse(tbDagen.Text);




            try
            {

                if (cmbFiets.SelectedIndex > -1)
                {
                    ComboBoxItem comboBoxStringBedrag = (ComboBoxItem)cmbFiets.SelectedItem;
                    string geknitString = comboBoxStringBedrag.Content.ToString();
                    string[] bedrag = geknitString.Split('€');
                    _cmbTotaalbedrag = double.Parse(bedrag[1]);

                    
                    lbBestelling.Items.Add(geknitString + ", " + _dagen + " dagen," + " totaal= €" + _cmbTotaalbedrag * _dagen + ",00");
                    totaal += (_cmbTotaalbedrag * _dagen);
                    KrijgtTerug -= (_cmbTotaalbedrag * _dagen);
                }
                else if (cmbVerzekering.SelectedIndex > -1)
                {
                    ComboBoxItem comboBoxStringVerzekering = (ComboBoxItem)cmbVerzekering.SelectedItem;
                    string geknitString1 = comboBoxStringVerzekering.Content.ToString();
                    string[] bedrag1 = geknitString1.Split('€');
                    _cmbTotaalbedrag1 = double.Parse(bedrag1[1]);

                   
                    lbBestelling.Items.Add(geknitString1 + ", " + _dagen + " dagen," + " totaal= €" + _cmbTotaalbedrag1 * _dagen + ",00");
                    totaal += (_cmbTotaalbedrag1 * _dagen);
                    KrijgtTerug -= (_cmbTotaalbedrag1 * _dagen);
                }
                else
                {
                    ComboBoxItem comboBoxStringService = (ComboBoxItem)cmbService.SelectedItem;
                    string geknitString2 = comboBoxStringService.Content.ToString();
                    string[] bedrag2 = geknitString2.Split('€');
                    _cmbTotaalbedrag2 = double.Parse(bedrag2[1]);

                   
                    lbBestelling.Items.Add(geknitString2 + ", " + _dagen + " dagen," + " totaal= €" + _cmbTotaalbedrag2 * _dagen + ",00");
                    totaal += (_cmbTotaalbedrag2 * _dagen);
                    KrijgtTerug -= (_cmbTotaalbedrag2 * _dagen);
                }


                tbPrijs.Text = "€ " + totaal + ",00 ";
                tbPrijs1.Text = "€ " + KrijgtTerug + ",00 ";
                cmbVerzekering.Visibility = Visibility.Visible;
                cmbFiets.Visibility = Visibility.Visible;
                cmbService.Visibility = Visibility.Visible;
                cmbFiets.SelectedIndex = -1;
                cmbService.SelectedIndex = -1;
                cmbVerzekering.SelectedIndex = -1;
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
                tbDagen.Text = "0";




            }
            catch (Exception)
            {
                MessageBoxResult myResult = MessageBox.Show("Oeps selecteer een product AUB", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                if (myResult == MessageBoxResult.Cancel)
                {
                    this.Close();
                }
                return;
            }





        }





        void OnDropDownOpened(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == true)
            {
                cmbService.Visibility = Visibility.Hidden;
                cmbVerzekering.Visibility = Visibility.Hidden;
            }
        }

        void OnDropDownClosed(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == false)
            {
                cmbService.Visibility = Visibility.Hidden;
                cmbVerzekering.Visibility = Visibility.Hidden;
            }
        }
        void OnDropDownOpened1(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == true)
            {
                cmbFiets.Visibility = Visibility.Hidden;
                cmbService.Visibility = Visibility.Hidden;
            }
        }

        void OnDropDownClosed1(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == false)
            {
                cmbFiets.Visibility = Visibility.Hidden;
                cmbService.Visibility = Visibility.Hidden;
            }
        }
        void OnDropDownOpened2(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == true)
            {
                cmbVerzekering.Visibility = Visibility.Hidden;
                cmbFiets.Visibility = Visibility.Hidden;
            }
        }

        void OnDropDownClosed2(object sender, EventArgs e)
        {
            if (cmbFiets.IsDropDownOpen == false)
            {
                cmbVerzekering.Visibility = Visibility.Hidden;
                cmbFiets.Visibility = Visibility.Hidden;
            }
        }

        private void lbBestelling_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {



            if (lbBestelling.SelectedIndex != 1)
            {
                string myString = lbBestelling.SelectedItem.ToString();
                string[] myStringArray;
                myStringArray = myString.Split('€');

                try
                {
                    double regel = double.Parse(myStringArray[2]);
                    totaal = totaal - regel;
                    tbPrijs.Text = totaal.ToString("€0.00");
                   




                    object verwijderen = lbBestelling.SelectedItem;

                    lbBestelling.SelectedItem = null;
                    lbBestelling.Items.Remove(verwijderen);


                }
                catch (Exception)
                {
                    MessageBox.Show("oeps er is iets fout gegaan");
                    throw;

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lbBestelling.Items.Count == 0)
            {
                MessageBox.Show("zorg dat je een bestelling hebt geplaats", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBoxResult myResult = MessageBox.Show("heeft de klant al betaald?", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Question);
                     if (myResult == MessageBoxResult.Yes)
                {
                    tbPrijs.Text = "€ " + totaal + ",00 ";
                    cmbVerzekering.Visibility = Visibility.Visible;
                    cmbFiets.Visibility = Visibility.Visible;
                    cmbService.Visibility = Visibility.Visible;
                    cmbFiets.SelectedIndex = -1;
                    cmbService.SelectedIndex = -1;
                    cmbVerzekering.SelectedIndex = -1;
                    lbBestelling.Items.Clear();
                    lbBestelling1.Items.Clear();
                    tbDagen.Text = "0";
                    tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
                    tbPrijs.Text = "€0,00";
                    tbPrijs1.Text = "€0,00";
                    KrijgtTerug = 0;
                }
                else
                {
                    MessageBox.Show("Laat eerst de klant betalen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer1.Text);

            _Totaalbedrag = (_AantalGeld * _5Cent);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _5Cent + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer2.Text);

            _Totaalbedrag = (_AantalGeld * _10Cent);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _10Cent + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer3.Text);

            _Totaalbedrag = (_AantalGeld * _20Cent);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _20Cent + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer4.Text);

            _Totaalbedrag = (_AantalGeld * _50Cent);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _50Cent + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer5.Text);

            _Totaalbedrag = (_AantalGeld * _1Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _1Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer6.Text);

            _Totaalbedrag = (_AantalGeld * _2Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _2Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer7.Text);

            _Totaalbedrag = (_AantalGeld * _5Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _5Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer8.Text);

            _Totaalbedrag = (_AantalGeld * _10Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _10Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }


        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer9.Text);

            _Totaalbedrag = (_AantalGeld * _20Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _20Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer10.Text);

            _Totaalbedrag = (_AantalGeld * _50Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _50Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer11.Text);

            _Totaalbedrag = (_AantalGeld * _100Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _100Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            _AantalGeld = double.Parse(tbKeer12.Text);

            _Totaalbedrag = (_AantalGeld * _200Euro);
            lbBestelling1.Items.Add(_AantalGeld + " Keer" + " €" + _200Euro + ".00");
            tbPrijs1.Text = (KrijgtTerug += _Totaalbedrag).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
//handmatige invoer
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            _Handmatig = double.Parse(tbHandmatig.Text);

            tbPrijs1.Text = (KrijgtTerug += _Handmatig).ToString("€0.00");
            if (KrijgtTerug < 0)
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                tbPrijs1.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
