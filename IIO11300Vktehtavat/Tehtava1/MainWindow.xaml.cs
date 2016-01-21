/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2016 Modified: 13.1.2016
* Authors: Tero ,Esa Salmikangas
*/
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

using JAMK.IT.IIO11300;


namespace Tehtava1
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            try
            {



                if (double.Parse(txtHeigt.Text.ToString()) <= 0 || double.Parse(txtWidht.Text.ToString()) <= 0 || double.Parse(txtFrameWidith.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Syötetty arvo on 0 tai pienempi. Määritä todelliset arvot");
                    return;
                }

                double result;
                result = BusinessLogicWindow.CalculatePerimeter(double.Parse(txtHeigt.Text.ToString()), double.Parse(txtWidht.Text.ToString()));
                txtPerimeter.Text = result.ToString();

                result = BusinessLogicWindow.CalculateWindowArea(double.Parse(txtHeigt.Text.ToString()),
                                                                    double.Parse(txtWidht.Text.ToString()),
                                                                    double.Parse(txtFrameWidith.Text.ToString()) );
                txtWindowArea.Text = result.ToString();

                result = BusinessLogicWindow.CalculateFrameArea(double.Parse(txtHeigt.Text.ToString()),
                                                                    double.Parse(txtWidht.Text.ToString()),
                                                                    double.Parse(txtFrameWidith.Text.ToString()) );
                txtFrameArea.Text = result.ToString();

                    

            }
            catch (Exception ex)
            {
                

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //yield to an user that everything okay
            }
        }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
            //sulkee käynnissä olevan sovelluksen
      Application.Current.Shutdown();
    }

        private void btnCalculateOO_Click(object sender, RoutedEventArgs e)
        {
            //olion avulla lasketaan pinta-ala piiri ja hinta
            Ikkuna ikk = new Ikkuna();
            ikk.Leveys = double.Parse(txtWidht.Text);
            ikk.Korkeus = double.Parse(txtHeigt.Text);
            //ikk.korkeus = double.Parse(txtHeigt.Text);
            //pinta-alan laskeminen kutsumalla metodia 
            txtWindowArea.Text = ikk.LaskePintaAla().ToString();

            //vaihtoehto 2, pinta-ala on olion ominaisuus
            txtFrameArea.Text = ikk.PintaAla.ToString();
        }
    }

  
}
