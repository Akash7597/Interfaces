using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IRandomizable
    {
        double GetRandomNum(double UB);
    }
    public class MyRandomizer:IRandomizable
    {
        public MyRandomizer() { }
        public double GetRandomNum(double UB)
        {
            Random rnumGen = new Random();
            double s = rnumGen.NextDouble();
            return s * UB;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRandomizer Temp = new MyRandomizer();
            string str;
            do
            {
                Console.WriteLine("Enter a number for the upper bound: ");
                str = Console.ReadLine();
                try
                {
                    double upperBound = Double.Parse(str);
                    Console.WriteLine("Random number between 0 and {1}: {0}",
                        Temp.GetRandomNum(upperBound), upperBound);
                }
                catch (Exception e) { }
            }
            while (str != "exit");
            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }
    }

}
