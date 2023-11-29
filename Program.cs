using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaZrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", "2000kW", "6000km");
            Console.WriteLine(x380.ToString());

            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", "75kW", "870km");
            Console.WriteLine(C162.ToString());

            Zrakoplov PC21 = new Zrakoplov("Pilatus", "1200 kW", "1333 km");
            Console.WriteLine(PC21.ToString());

            Console.ReadKey();
        }
    }
}
