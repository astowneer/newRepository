using System;

namespace forgit
{
    class Program
    {
        public static bool IsPrime(uint n)
        {
            var result = true;
            if (n > 1)
            {
                for (uint i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else result = false;

            return result;
        }


        static void PrintAllQPow2p1PrimeNumbers(uint n)
        {
            Console.WriteLine("Простi числа, якi задовiльняють умову q^2+1");
            for (uint i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    double exsprecion = Math.Sqrt(i - 1.0) * Math.Sqrt(i - 1.0) + 1;
                    if (exsprecion == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }


        static void PrintAllFibonacciPrimeNumbers(uint n)
        {
            Console.WriteLine("Числа Фiбоночi, що є простими числами");
            uint first = 0;
            uint second = 1;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(first))
                {
                    Console.WriteLine(first);
                }
                if (IsPrime(second))
                {
                    Console.WriteLine(second);
                }
                first += second;
                second += first;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введiть значення границi дiапазону = ");
            uint num = Convert.ToUInt32(Console.ReadLine());
            uint n;
            do
            {
                Console.WriteLine("Введiть значення n = 1, 2\n0 - вихiд");
                n = Convert.ToUInt32(Console.ReadLine());
                if (n == 1) PrintAllQPow2p1PrimeNumbers(num);
                else if (n == 2) PrintAllFibonacciPrimeNumbers(num);
            } while (n != 0);
        }
    }
}
