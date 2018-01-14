using AnalyzeBitcoin.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace AnalyzeBitcoin
{
    class Program
    {
        static string file = @"myOutput.csv";

        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 60000;
            aTimer.Enabled = true;


            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var current = PriceRetriver.GetCurrentBitcoinPrice();

            if (current != null)
            {
                string first = current.bpi.usd.rate_float.ToString();
                string second = current.time.updatedISO;
                string csvRow = string.Format("{0},{1}{2}", first, second, Environment.NewLine);

                File.AppendAllText(file, csvRow);
            }
        }
    }
}
