// Напишите программу, которая на вход принимает два числа и выдаёт, какое число
//большее, а какое меньшее.

//  Задача №2

Console.WriteLine("Введите число 1");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 > num_2)
    {
     Console.WriteLine("Число 1 больше числа 2");
    }
else
    {
     Console.WriteLine("Число 2 больше числа 1");
    }
