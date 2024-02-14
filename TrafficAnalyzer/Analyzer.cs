using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TrafficAnalyzer
{
    public class Analyzer
    {
        public static List<string> CollectionData(string filepath)
        {
            List<string> rawData = new List<string>();
            using (StreamReader reader = new StreamReader(filepath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    rawData.Add(line);
                }
            }
            return rawData;
        }
    }
}
