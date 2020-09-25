using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp03
{
    class Program
    {
        static void Main(string[] args)
        {
                 //演習3-1-1
           var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

           var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (exists)
                Console.WriteLine("存在してます");
            else
                Console.WriteLine("存在してません");

            //演習3-1-2
            numbers.ForEach(n => Console.WriteLine(n/2.0));

            //演習3-1-3
           IEnumerable<int> query = numbers.Where(n => n<= 50);
            foreach (var item in query) {
                Console.WriteLine(item);
            }



        }
    }
}
                  