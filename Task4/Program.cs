using System;
using InputHelper;

namespace Task4
{
    class Program
    {
        static string ConvertNumber(double number, int numSystem)
        {
            string result = "0.";
            for (int i = 0; i < 5; i++)
            {
                number = (number - (int)number) * numSystem;
                result += (int)number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 4\n=================");
            Console.WriteLine("Даны действительное число х, натуральное число q (0 <= х < 1, q >= 2).\n" +
                              "Получить пять цифр q-ичного представления числа х, т. е. получить последовательность целых неотрицательных а(-1) ..., а(-5) такую," +
                              "что x = a(-1) * q^-1 + ... + a(-5) * q^-5 + r, (r < q^-5).\n" +
                              "=================");
            double x;
            Console.Write("Введите число x: ");
            while (!double.TryParse(Console.ReadLine(), out x) || x >= 1 || x < 0)
                Console.WriteLine("Ошибка! Введите вещественное число, которое входит в диапазон [0;1).");
            int q = Input.ReadInt("Введите число q: ", 2);

            string result = ConvertNumber(x, q);

            Console.WriteLine($"\nЧисло {x} в {q}-ичном представлении: {result}...");
            Console.WriteLine($"Получившаяся последовательность (пять цифр {q}-ичного представления числа {x}): ");
            for (int i = 0; i < 5; i++)
                Console.Write($"{result.Substring(2 + i, 1)} ");
        }
    }
}
