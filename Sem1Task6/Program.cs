﻿// Задача №6 

//Напишите программу, которая на вход принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).

//ввести число. в идеале добавить проверку числа. Не добавила проверку на 0
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

//проверка на четное. если четное 1 ветка, иначе ветка 2
if (a % 2 == 0)
    {
    System.Console.WriteLine("Число: " + a + " четное");
    }
else 
    {
    System.Console.WriteLine("Число: " + a + " нечетное");
    }