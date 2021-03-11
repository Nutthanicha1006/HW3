using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double X, Y, t1, p1, t2, p2;

            Console.Write("");
            mode = Console.ReadLine();
            Console.Write("");
            X = double.Parse(Console.ReadLine());
            Console.Write("");
            Y = double.Parse(Console.ReadLine());

            if (mode == "time")
            {
                if (X >= 0)
                {
                    t1 = X;
                    p1 = Math.Pow((X - 1), 2);
                    Console.WriteLine("{0}, {1}", t1, p1);
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else if (mode == "price")
            {
                if (X >= 0)
                {
                    t2 = (Math.Sqrt(Y) + 1);
                    p2 = Y;
                    Console.WriteLine("{0}, {1}", t2, p2);
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }

            Console.ReadLine();
            
        }
    }
}
