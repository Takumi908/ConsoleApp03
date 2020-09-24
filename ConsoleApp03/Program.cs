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
        //デリゲートの宣言'(int型の引数を受け取ってbool値を返すメソッド)
        public delegate bool Judgment(int value);

        static void Main(string[] args)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //匿名メソッド
            //int count = Count(numbers,delegate(int n)　 { return (n >= 5); });
            int count = Count(numbers, n =>n.ToString().Contains('3'));  //5～8

            Console.WriteLine(count);
        }

        public static int Count(int[] numbers, Judgment judge)
        {
            
            int count = 0;
            foreach(var n in numbers)
            {
                if (judge(n)==true)
                    count++;
            }
            return count;
        }
    }
}
