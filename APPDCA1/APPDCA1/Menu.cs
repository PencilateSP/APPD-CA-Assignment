﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPDCA1
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            
            //Guide.TestStationRoute();
            //Guide.TestingStationMtd();
            //Guide.Testing();
            //Console.WriteLine("INITIALISING GRAPH");
            //GraphRoute.initStationIndex();
            //GraphRoute.initGraph();
            //GraphRoute.TestGraph   

            //GraphRoute.TestGraphRoute();

            //FileIO.textMRTFileReaderToDB("..\\..\\resources\\MRT.txt");
            //FileIO.textFareFileReaderToDB("..\\..\\resources\\fares.txt");

            Guide.initLineArray();
            Guide.TestStationRoute();



            Console.ReadKey();
        }
    }
}
