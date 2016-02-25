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

namespace H6_databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HockeyLeague smliiga;
        List<HockeyTeam> liigajoukkueet;
        int osoitin;
        public MainWindow()
        {
            InitializeComponent();
            AlustaKontrollit();
        }
        private void AlustaKontrollit()
        {
            //täyttetän comboboxi listan alkioilla
            List<String> joukkueet = new List<string>();
            joukkueet.Add("Ilves");
            joukkueet.Add("JYP");
            joukkueet.Add("Tappara");

            cbTeams.ItemsSource = joukkueet;
            //perustetaan smliiga:
            smliiga = new HockeyLeague();
            liigajoukkueet = smliiga.GetTeams();
        }

        private void btnGetSetting_Click(object sender, RoutedEventArgs e)
        {
            //tämä koodi lukee app.configin asetuken UserName asetettu asetukset ja settings.
            btnGetSetting.Content = H6_databinding.Properties.Settings.Default.UserName;
            
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //idotaan kokoelma stackpanelin datacontek
            spLiiga.DataContext = liigajoukkueet ;
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            //siirretään osoitinta kokoelmassa yhdellä eteenpäin 
            osoitin++;
            spLiiga.DataContext = liigajoukkueet[osoitin];
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            osoitin--;
            spLiiga.DataContext = liigajoukkueet[osoitin];
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
            //listätään kokoelmaan uusi joukkue 
            HockeyTeam uusi = new HockeyTeam();
            liigajoukkueet.Add(uusi);
            osoitin = liigajoukkueet.Count - 1;
            spLiiga.DataContext = liigajoukkueet[osoitin];
        }
    }
}
