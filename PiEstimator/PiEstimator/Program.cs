using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;

            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;

            // TODO: Calculate Pi

            double x = 0;
            double y = 0;

            int count = 0;

            double pTotal = 0;
            double pInCircle = 0;
            while (count < n)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                //find if point is in circle. if it is, add to pInCircle
                if (Math.Sqrt(x * x + y * y) <= 1)
                {
                    count++;
                    pInCircle++;
                    pTotal++;
                }
                else
                {
                    count++;
                    pTotal++;
                }
            }

            pi = 4 * (pInCircle / pTotal);

            return pi;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}