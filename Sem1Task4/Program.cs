// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  Задача №4

//ввести 3 числа
Console.WriteLine("Введите число 1");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num_3 = int.Parse(Console.ReadLine());

//проверка какое число больше. число 1 > числа 2
if (num_1 > num_2)
{
//число 1 > числа 2
if (num_1 > num_2)
//число 1 > числа 3
    if (num_1 > num_3)
    {
        Console.WriteLine("Максимальное число 1");
    }

    else
//число 1 < числа 3
    {
        Console.WriteLine("Максимальное число 3");
    }
}

else
{
//число 1 < числа 2
    if (num_2 > num_3)
    {//число 3 < числа 2
        Console.WriteLine("Максимальное число 2");
    }
    else
    {//число 2 < числа 3
        Console.WriteLine("Максимальное число 3");
    }
}