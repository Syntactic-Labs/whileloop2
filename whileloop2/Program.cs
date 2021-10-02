using System;

namespace whileloop2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////while loop
            //var x = 0;
            //while (x < 10)
            //{
            //    x++;
            //}
            ////Console write outside shows final result... Console write inside shows each execution
            //Console.WriteLine($"{x}");
            //==================================================================================
            //while loop that cubes the idx variable till idx variable starts at 25
            var idx = 1;
            while (idx <= 25)
            {
                Console.Write($"{idx * idx * idx}, ");
                idx = idx + 2;
            }
            //===================================================================================
            //Do...While loop- Does the something before it checks the boolean expression
            var x = 0;
            do
            {
                x++;
            } while (x < 10);
            //console write is just to separate examples
            Console.WriteLine();
            Console.WriteLine($"{x}");
        }
    }
}
