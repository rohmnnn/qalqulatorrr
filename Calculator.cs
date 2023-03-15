using System;

namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Add(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Sub(a, b));


            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}

    