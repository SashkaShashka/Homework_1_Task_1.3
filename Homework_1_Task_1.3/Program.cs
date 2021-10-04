using System;

namespace Homework_1_Task_1._3
{
    class Program
    {
        static bool Read(out int num)
        {
            num = 0;
            while (true)
            {
                Console.Write("Введите значение: ");
                string text = Console.ReadLine();
                if (text.Length == 0)
                    return false;
                if (int.TryParse(text, out num) && num >= -1000 && num <= 1000)
                    return true;
                else
                    Console.WriteLine("Вы ввели что не понятное! Если хотите закончить ввод введите пустую строку.");
            }

        }
        static void Main(string[] args)
        {
            int num;
            long sum = 0;
            int max_val = int.MinValue;
            int min_val = int.MaxValue;
            long count = 0;

            while (Read(out num))
            {
                sum += num;
                if (num < min_val)
                    min_val = num;
                if (num > max_val)
                    max_val = num;
                ++count;
            }

            if (count != 0)
            {
                Console.WriteLine("Cумма введенных чисел: " + sum);
                Console.WriteLine("Количество введенных чисел: " + count);
                Console.WriteLine("Максимальное введенное число: " + max_val);
                Console.WriteLine("Минимальное введеное число: " + min_val);
                Console.WriteLine("Среднее чисел: " + sum / count);
            }
            else
            {
                Console.WriteLine("Cумма введенных чисел: 0");
                Console.WriteLine("Количество введенных чисел: 0");
                Console.WriteLine("Максимальное введенное число: не вычеслено ");
                Console.WriteLine("Минимальное введеное число: не вычеслено");
                Console.WriteLine("Среднее чисел: 0");
            }


        }

    }
}
