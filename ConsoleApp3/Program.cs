using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = { 1, 2, 3, 4, 5, 60, 61, 64, 45, 87, 100, 21, 56 };
            var result =
                from c in scores
                where c > 80
                select c;

            result.ForEach(x => { Console.WriteLine(x.ToString()); });


        }
    }
}
