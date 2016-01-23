﻿using System;
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
        }

        private void btDraw_Click(object sender, RoutedEventArgs e)
        {

           
            BLWinLotto.Lotto lotto = new BLWinLotto.Lotto(39, 7, 3);



            lstDraw.Items.Add(string.Join(" ", lotto.GetMainRow()));
            
        }
    }
}
