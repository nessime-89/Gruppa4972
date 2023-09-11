// Задача №8 

//Напишите программу, которая на вход принимает число (N), а на выходе показывает
//все чётные числа от 1 до N.

Console.WriteLine("Введите число больше 1");
int NumN = int.Parse(Console.ReadLine());

for (int i = 1; i <= NumN; i++)
{
    if (i % 2 == 0)
        {
        System.Console.WriteLine(i + ", ");
        }
}