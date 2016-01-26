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

//using System.Diagnostics;

namespace WinLotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] games = {"Lotto", "Viking", "Eurojackpot" };
            comboBox.Items.Add("Lotto");
            comboBox.Items.Add("Viking");
            comboBox.Items.Add("Eurojackpot");

            comboBox.SelectedIndex = 0;
        }

        private void btDraw_Click(object sender, RoutedEventArgs e)
        {

           
            BLWinLotto.Lotto lotto = new BLWinLotto.Lotto(39, 7, 3);
            BLWinLotto.Lotto viking = new BLWinLotto.Lotto(48, 6, 0);

           BLWinLotto.Lotto euroMain = new BLWinLotto.Lotto(50, 5, 0);
           BLWinLotto.Lotto euroStar = new BLWinLotto.Lotto(10, 2, 0);

            string gameType = comboBox.SelectedItem.ToString();

            switch (gameType) {
                case "Lotto":
                    
                    lstDraw.Items.Add(string.Join(" ", lotto.GetMainRow())
                 + " - " +
                string.Join(" ", lotto.GetExtraRow())
                );
                    break;

                case "Viking":
                    lstDraw.Items.Add(string.Join(" ", viking.GetMainRow()));
                    

                    break;

                case "Eurojackpot":
                    lstDraw.Items.Add(string.Join(" ", euroMain.GetMainRow())
               + " - " +
               string.Join(" ", euroStar.GetMainRow())
               );
                    
                    break;

                default:
                    MessageBox.Show("Something horrible happend");
                    return;

            }

            



        }
    }
}
