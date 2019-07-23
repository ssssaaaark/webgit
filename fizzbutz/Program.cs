using System;

namespace fizzbutz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 21; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIzzBuzz");
                }
                
                else if (i % 5 == 0)

                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
