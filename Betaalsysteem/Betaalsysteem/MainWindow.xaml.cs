using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Betaalsysteem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        string _cmbBoxString;
        string[] _geknipteString;

        double _AantalGeld = 0;
        double _Handmatig = 0;

        //geld
        double _dagen = 0;

        double totaal = 0;
        double KrijgtTerug = 0;

        double _cmbTotaalbedrag = 0.00;

        public MainWindow()
        {
            //idle timer, dit sluit de aplicatie af
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pbStatus.Value--;
           
        }


        // dit is de code dat er voor zorgt dat het listbox geupdate worden en ook de totaalprijs van listbox.
        private void Bestel_Artikel(object sender, RoutedEventArgs e)
        {
         
            try
            {
                pbStatus.Value = 60;
                _dagen = double.Parse(tbDagen.Text);

                if (cmbFiets.SelectedIndex > -1)
                {
                    //dit zet het fiets combobox in een string naar de listbox.
                    ComboBoxItem comboBoxStringBedrag = (ComboBoxItem)cmbFiets.SelectedItem;
                    string cmbString = comboBoxStringBedrag.Content.ToString();
                    string[] cmbBedrag = cmbString.Split('€');
                    _cmbTotaalbedrag = double.Parse(cmbBedrag[1]);
                    _cmbTotaalbedrag = _cmbTotaalbedrag * _dagen;

                    lbBestelling.Items.Add(cmbString + ", " + _dagen + " dagen," + " totaal= € " + _cmbTotaalbedrag);
                    totaal += _cmbTotaalbedrag;
                    KrijgtTerug -= _cmbTotaalbedrag;
                }
                else if (cmbVerzekering.SelectedIndex > -1)
                {
                    ComboBoxItem comboBoxStringBedrag = (ComboBoxItem)cmbVerzekering.SelectedItem;
                    string cmbString = comboBoxStringBedrag.Content.ToString();
                    string[] cmbBedrag2 = cmbString.Split('€');
                    _cmbTotaalbedrag = double.Parse(cmbBedrag2[1]);
                    _cmbTotaalbedrag = _cmbTotaalbedrag * _dagen;

                    lbBestelling.Items.Add(cmbString + ", " + _dagen + " dagen," + " totaal= € " + _cmbTotaalbedrag);
                    totaal += _cmbTotaalbedrag;
                    KrijgtTerug -= _cmbTotaalbedrag;
                }
                else if (cmbService.SelectedIndex > -1)
                {
                    ComboBoxItem comboBoxStringBedrag = (ComboBoxItem)cmbService.SelectedItem;
                    string cmbString = comboBoxStringBedrag.Content.ToString();
                    string[] cmbBedrag3 = cmbString.Split('€');
                    _cmbTotaalbedrag = double.Parse(cmbBedrag3[1]);
                    _cmbTotaalbedrag = _cmbTotaalbedrag * _dagen;

                    lbBestelling.Items.Add(cmbString + ", " + _dagen + " dagen," + " totaal= € " + _cmbTotaalbedrag);
                    totaal += _cmbTotaalbedrag;
                    KrijgtTerug -= _cmbTotaalbedrag;
                }
                InitializeSettings();

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

        private void InitializeSettings()
        {
            tbPrijs.Text = "€ " + totaal.ToString("0.00");
            afrekenenPrijs.Text = "€ " + KrijgtTerug.ToString("0.00");
            cmbVerzekering.Visibility = Visibility.Visible;
            cmbFiets.Visibility = Visibility.Visible;
            cmbService.Visibility = Visibility.Visible;
            cmbFiets.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            cmbVerzekering.SelectedIndex = -1;
            afrekenenPrijs.Foreground = new SolidColorBrush(Colors.Red);
            tbDagen.Text = "0";

        }


        private void lbBestelling_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            bool input = true;
            double prijs = 0.00;
            try
            {
                pbStatus.Value = 60;
                if (lbBestelling.SelectedIndex != -1)
                {
                    _cmbBoxString = lbBestelling.SelectedItem.ToString();
                    _geknipteString = _cmbBoxString.Split('€');
                    string temPrijs = _geknipteString[2];
                    prijs = double.Parse(temPrijs);
                    input = true;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ops, er is iets misgegaan!");
            }

            if (input == true)
            {
                object temp = lbBestelling.SelectedItem;
                lbBestelling.SelectedItem = null;
                lbBestelling.Items.Remove(temp);
                totaal = totaal - prijs;
                KrijgtTerug = KrijgtTerug + prijs;
                lbBestelling.Items.Remove(lbBestelling.SelectedItem);
                tbPrijs.Text = totaal.ToString("0.00");
                afrekenenPrijs.Text = KrijgtTerug.ToString("0.00");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pbStatus.Value = 60;
            if (lbBestelling.Items.Count == 0)
            {
                MessageBox.Show("zorg dat je een bestelling hebt geplaats", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBoxResult myResult = MessageBox.Show("heeft de klant al betaald?", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (myResult == MessageBoxResult.Yes)
                {
                    InitializeSettings();
                }
                else
                {
                    MessageBox.Show("Laat eerst de klant betalen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private void tbDagen_GotFocus(object sender, RoutedEventArgs e)
        {
            pbStatus.Value = 60;
            tbDagen.Text = "";
        }

        private void Klok_click(object sender, RoutedEventArgs e)
        {
            pbStatus.Value = 60;
            Klok win2 = new Klok();
            win2.Show();
            this.Hide();
        }

        private void rekenmachine_click(object sender, RoutedEventArgs e)
        {
            pbStatus.Value = 60;
            Rekenmachine win2 = new Rekenmachine();
            win2.Show();
            this.Hide();
        }

        private void tbHandmatig_GotFocus(object sender, RoutedEventArgs e)
        {
            pbStatus.Value = 60;
            tbHandmatig.Text = "";
        }

        private void cmbFiets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pbStatus.Value = 60;
            if (cmbFiets.SelectedIndex != -1)
            {
                cmbService.Visibility = Visibility.Hidden;
                cmbVerzekering.Visibility = Visibility.Hidden;
            }
            else
            {
                cmbService.Visibility = Visibility.Visible;
                cmbVerzekering.Visibility = Visibility.Visible;
            }
        }

        private void cmbVerzekering_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pbStatus.Value = 60;
            if (cmbVerzekering.SelectedIndex != -1)
            {
                cmbService.Visibility = Visibility.Hidden;
                cmbFiets.Visibility = Visibility.Hidden;
            }
            else
            {
                cmbService.Visibility = Visibility.Visible;
                cmbFiets.Visibility = Visibility.Visible;
            }
        }

        private void cmbService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pbStatus.Value = 60;
            if (cmbService.SelectedIndex != -1)
            {
                cmbFiets.Visibility = Visibility.Hidden;
                cmbVerzekering.Visibility = Visibility.Hidden;
            }
            else
            {
                cmbFiets.Visibility = Visibility.Visible;
                cmbVerzekering.Visibility = Visibility.Visible;
            }
        }



    }
}
