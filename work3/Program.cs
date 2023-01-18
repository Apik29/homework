Console.WriteLine("Добро пожаловать в программу, которая на вход принимает число и выдаёт, является ли число чётным");
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 1)
{
    Console.WriteLine( "Число " + number1 + "является: Нечетным" ) ;
}
    else
{
    Console.WriteLine("Число " + number1 + "является: Четным") ;
}