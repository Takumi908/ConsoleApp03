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

            var list = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Camberra","Hong Kong", 
            };

           // list.ForEach (s => Console.WriteLine(s)) ;

            list.FindAll(s => s.ToUpper(s)).ForEach(s => Console.WriteLine(s));



            /*
           foreach (var s in name) 
            Console.WriteLine(s);
            */
        }
    }
}
