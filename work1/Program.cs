using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в программу,  которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
        Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine("Первое число " + number1 + " больше чем второе " + number2);
        }
        else
        {
            Console.WriteLine("Второе число " + number2 + " больше чем первое " + number1);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}