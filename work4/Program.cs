Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int i = 0;
int N = number;
int b = 0;
int countEven = (N / 2);

while (i < countEven)
{
b = b + 2;
Console.Write(b);
Console.Write(", ");
i = i + 1;
}
if (i == 0) Console.Write("Четных чисел нет ");
count = count + 1;
Console.WriteLine();