using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int addNumber = Cal.AddCal(2, 4);
            int multiNumber = Cal.MultiCal(2, 4);
            Console.WriteLine($"Adding Numbers {2} + {4} = {addNumber}");
            Console.WriteLine($"Multiply Numbers {2} * {4} = {multiNumber}");
            Console.ReadKey();
        }
    }
}
