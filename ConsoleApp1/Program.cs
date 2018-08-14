using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = from n in arr
                        where n > 1 && n < 6
                        group n by n % 2;

            foreach (var element in query)
                Console.WriteLine(element);
            Console.ReadKey();
        }
    }
}
