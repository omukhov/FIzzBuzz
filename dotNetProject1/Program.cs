using System;

namespace dotNetProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Выберите функцию, если нужно узнать простые числа введите 1, если FizzBuzz введите 2: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                SimpleNumbers();
            }
            if (k == 2)
            {
                FizzBuzz();
            }
        }
        static void SimpleNumbers() 
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
        static void FizzBuzz()
        {
            Console.Write("Введите количество нужных вам чисел для функции: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
