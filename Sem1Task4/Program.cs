// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  Задача №4

Console.WriteLine("Введите число 1");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num_3 = int.Parse(Console.ReadLine());


if (num_1 > num_2)
{
    if (num_1 > num_3)
    {
        Console.WriteLine("Максимальное число 1");
    }
    else
    {
        Console.WriteLine("Максимальное число 3");
    }
}
else
{
    if (num_2 > num_3)
    {
        Console.WriteLine("Максимальное число 2");
    }
    else
    {
        Console.WriteLine("Максимальное число 3");
    }
}