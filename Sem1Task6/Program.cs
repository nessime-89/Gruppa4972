﻿// Задача №6 

//Напишите программу, которая на вход принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
    {
    System.Console.WriteLine("Число: " + a + " четное");
    }
else 
    {
    System.Console.WriteLine("Число: " + a + " нечетное");
    }