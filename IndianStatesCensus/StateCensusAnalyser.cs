using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStatesCensus
{
    class StateCensusAnalyser
    {
        /// <summary>
        /// loads the data directly from the csv file
        /// </summary>
        public int GetData()
        {
            string filepath = @"C:\Users\Milind\OneDrive\Desktop\all Programs\Indian_States_Census\IndianStatesCensus\Indian state census data\IndiaStateCensusData.csv";
            string[] data = File.ReadAllLines(filepath);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            return data.Length;
        }
    }
}
