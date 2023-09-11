// Задача №5

//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.

Console.WriteLine("Введите целое число бельше 0");
int NumN = int.Parse(Console.ReadLine());
int evNumN = (-1)*NumN;
while (evNumN < NumN)
{
    Console.Write (evNumN + ", ");
    evNumN++;
}

Console.WriteLine (NumN);

