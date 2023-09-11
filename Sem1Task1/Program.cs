//Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

//  Задача №1

Console.WriteLine("Введите число 1");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num_2 = int.Parse(Console.ReadLine());

if (num_1*num_1 == num_2)
    {
     Console.WriteLine("Число 2 является квадратом числа1");
    }
else
    {
     Console.WriteLine("Число 2 не является квадратом числа1");
    }
