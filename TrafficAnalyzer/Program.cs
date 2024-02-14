using System;
using System.IO;
using System.Runtime.Serialization;
using TrafficAnalyzer;

namespace TrafficAnalyzer
{
    public class Program
    {

        static void Main(string[] args)
        {
            string filepath = @"C:\Users\somesh\OneDrive\Desktop\statistics.txt";


            if (File.Exists(filepath))
            {
                try
                {
                    //Acceesing data from file adding into the list
                    List<string> rawData = Analyzer.CollectionData(filepath);


                    //perform Analysis

                    Dictionary<string, int> statistics = new Dictionary<string, int>();

                    foreach (string Ip in rawData)
                    {
                        // let's assume data entries are IP addresses
                        if (statistics.ContainsKey(Ip))
                        {
                            statistics[Ip]++;
                        }
                        else
                        {
                            statistics[Ip] = 1;
                        }
                    }

                    // Display 

                    Console.WriteLine("Analysis Results:");

                    foreach (var entry in statistics)
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value} occurrences");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            else
            {
                Console.WriteLine("File is not Existed");

            }
        }
    }
}

