// Напишите программу, которая принимает на вход
//два числа и проверяет, является ли одно число квадратом другого.


//ввести числа
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

//проверяет, является ли одно число квадратом другого
Console.WriteLine( num1*num1 == num2 || num2*num2 == num1 ? "да"  : "нет" );
