using System;
using System.Linq;
using System.Collections.Generic;

namespace FizBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(e => Console.WriteLine($"{e}: {(e % 3 == 0 ? "Fizz " : string.Empty)}{(e % 5 == 0 ? "Buzz" : string.Empty)}".TrimEnd()));
            Console.ReadKey();
        }
    }
}
