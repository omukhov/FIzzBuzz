using System;

namespace dotNetProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество нужных вам простых чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 && i % 1 == 0)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    Console.Write("{0} ", i);
                }                
            }
            Console.ReadKey();
        }
    }
}
