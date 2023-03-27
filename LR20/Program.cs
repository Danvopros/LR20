using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Таблица считания");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{i + j}\t");
                }
                Console.WriteLine();

            }
        }
    }
}
