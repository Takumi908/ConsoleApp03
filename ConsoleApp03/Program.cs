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

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Camberra","Hong Kong", 
            };

            //遅延
            IEnumerable<string> query = names.Where(s => s.Length <= 5).ToArray();
            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            names[0] = "Osaka";
            foreach(var item in query) {
                Console.WriteLine(item);
            }

            names.ConvertAll(s => s.ToUpper()).ForEach(s => Console.WriteLine(s));



            /*
           foreach (var s in name) 
            Console.WriteLine(s);
            */
        }
    }
}
