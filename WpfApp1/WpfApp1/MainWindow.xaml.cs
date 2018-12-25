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

namespace WpfApp1
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

        private void btnHome_Click(object sender, RoutedEventArgs e) //event that happens when button is clicked
        {
            MainWindow Home = new MainWindow(); //create new instance of MainWindow
            Home.Show(); //show MainWindow window
            this.Close(); //close current window
        }

        private void btnDirections_Click(object sender, RoutedEventArgs e) //event that happens when button is clicked
        {
            Directions Dir = new Directions(); //create new instance of Directions
            Dir.Show(); //show Directions window
            this.Close(); //close current window

        }

        private void btnDisplayLine_Click(object sender, RoutedEventArgs e) //event that happens when button is clicked
        {
            DisplayMRTLine Display = new DisplayMRTLine(); //create new instance of Display
            Display.Show(); //show Display window
            this.Close(); //close current window
        }
    }
}
