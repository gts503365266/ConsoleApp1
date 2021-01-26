using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Func<string> AAA = new Func<string>(() => (2 * 2).ToString());
            Console.WriteLine("AAA():" + AAA());


            Func<int, string> BBB = new Func<int, string>(m => (m * 2).ToString());
            Console.WriteLine("BBB():" + BBB(4));

            Action CCC = new Action(() => Console.WriteLine((2 * 2).ToString()));
            CCC();

            Action<int> DDD = new Action<int>(m => Console.WriteLine((m * 2).ToString()));
            DDD(9);
        }
    }
}
