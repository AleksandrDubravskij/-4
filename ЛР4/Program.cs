namespace ЛР4
{
    using System;

    class Program
    {
        static int SwapFirstAndLastDigit(int num)
        {
            int last = num % 10;
            int middle = (num / 10) % 10;
            int first = num / 100;

            return last * 100 + middle * 10 + first;
        }

        static void Main()
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int swappedNumber = SwapFirstAndLastDigit(number);
            Console.WriteLine($"Число после замены: {swappedNumber}");
        }
    }

}