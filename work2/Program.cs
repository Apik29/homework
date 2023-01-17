﻿using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

        Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int max = number1;

        if (number2 > max)
        {
            max = number2;
        }

        if (number3 > max)
        {
            max = number3;
        }

Console.WriteLine("Наибольшее из введённых чисел -> " + max);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}