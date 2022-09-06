// Подсчитывает количество введенных положительных чисел. Числа вводятся все сразу одной строкой, через пробел.
using System;

namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа. Числа вводятся в одну строку, разделенные пробелом.");
            string inputString = Console.ReadLine();
            
            int result = CountPositiveNumbers(inputString);
            Console.WriteLine($"Введено {result} положительных чисел");
        }
    
        static int CountPositiveNumbers(string input)
        {
            string[] numbers = input.Split(' ');
            int countPositiveNumbers = 0;

            for (int i = 0; i < numbers.Length; i++) if (Double.Parse(numbers[i]) > 0) countPositiveNumbers += 1;

        return countPositiveNumbers;
        }
    }
}
