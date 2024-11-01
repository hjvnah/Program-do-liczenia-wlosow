using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace programdoliczeniawlosow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
      

        private void Liczeniewlosow(object sender, TextChangedEventArgs e)
            {
            
                int obwodGlowy = int.Parse(Obwglowy.Text);
                int wysokoscCzola = int.Parse(DlCzola.Text);

                double promien = obwodGlowy / (2 * Math.PI);
                double powierzchnia = 4 * Math.PI * Math.Pow(promien, 2);
                double iloscWlosow = powierzchnia * 100;

                IlWlosow.Text = Math.Round(iloscWlosow).ToString();
            
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            Obwglowy.Text = string.Empty;  
            DlCzola.Text = string.Empty;
            IlWlosow.Text = string.Empty;

        }



    }

    }
    
