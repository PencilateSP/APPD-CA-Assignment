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
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for DisplayMRTLine.xaml
    /// </summary>
    public partial class DisplayMRTLine : Window
    {
        public DisplayMRTLine()
        {
            InitializeComponent();
            Guide.initLineArray();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) //event that happens when button is clicked
        {
            Guide.initLineArray(); //Invokes Guide.initLineArray() method
            string station = cmbxStationStrChooser.Text; //gets input from user
            string result = string.Empty;
            Station resultStat = new Station(); //creates new Station Object
            if (radStatName.IsChecked == true) //if StationName checkbox is checked
            {
                resultStat = Guide.SearchByStationName(station); //search for the input station code based on inputted station name
            }
            else //else if StationCode checkbox is checked
            {
                resultStat = Guide.SearchByStationCd(station); //search by station code based on user input
            }

            foreach (string StationCodeStr in resultStat.StationCode) //foreach loop
            {
                //result += string.Format("Displaying {0} Line:\r\n", StationCodeStr.Substring(0, 2));
                result += Guide.DisplayRoute(StationCodeStr); //output string
                result += "\r\n";
            }

            DisplayResults LineResult = new DisplayResults(); //create new instance of DisplayResults object
            LineResult.Show(); //show DisplayResults window
            LineResult.txtBoxDisplay.Text = "Displaying Line : \r\n" + "# - Represents the station that you selected\r\n" + result; //display output in textbox in DisplayResults window
            this.Hide(); //hides current window

        }

        private void Button_Click(object sender, RoutedEventArgs e) //event that happens when button is clicked
        {
            MainWindow Home = new MainWindow(); //create new instance of MainWindow object
            Home.Show(); //show MainWindow window
            this.Close(); //close current window
        }


        private void StationIdentifier_CheckChanged(object sender, RoutedEventArgs e)
        {
            //string statName = string.Empty;
            //string result = string.Empty;
            //Station resultStat = new Station();
            //bool SIChecked = true;
            if (radStatName.IsChecked.Value == true)
            {
                cmbxStationStrChooser.Items.Clear();
                foreach (string stationName in Guide.StationNameStringList())
                {
                    cmbxStationStrChooser.Items.Add(stationName);
                }
                //statName = cmbxStationStrChooser.Text;
                //resultStat.StationCode = Guide.SearchByStationName(statName).StationCode; //search for the input station code based on inputted station name
                //foreach (string StationCodeStr in resultStat.StationCode) //foreach loop
                //{
                //    result += Guide.DisplayRoute(StationCodeStr); //output string
                //}

            }
            else if (radStatCode.IsChecked.Value == true)
            {
                cmbxStationStrChooser.Items.Clear();
                foreach (string stationCode in Guide.StationCodeStringList())
                {
                    cmbxStationStrChooser.Items.Add(stationCode);
                }
            }

        }

    }
}
