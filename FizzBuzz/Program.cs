using System.CodeDom.Compiler;
using System;

namespace FizzBuzz
{
    class Result
    {
        public static void fizzBuzz(int n)
        {
            bool fizz;
            bool buzz;
            for (int i = 1; i <= n; i++)
            {
                fizz = false;
                buzz = false;

                int r3 = i % 3;
                if (r3 == 0)
                    fizz = true;
                int r5 = i % 5;
                if (r5 == 0)
                    buzz = true;

                if (fizz == false && buzz == false)
                    Console.WriteLine(i.ToString());
                else
                {
                    if (fizz == true && buzz == true)
                        Console.WriteLine("FizzBuzz");
                    else
                    {
                        if (fizz == true)
                            Console.WriteLine("Fizz");
                        if (buzz == true)
                            Console.WriteLine("Buzz");
                    }
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Result.fizzBuzz(n);
            Console.ReadLine();
        }
    }
}
