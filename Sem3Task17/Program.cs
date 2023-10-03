// Задача №17

//Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой
//находится эта точка.

// введение переменных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//по координатам точки определяем № четверти
int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

//печать результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadDate ("введите х");
int y = ReadDate ("введите y");

int res = QuterTest(x,y);

PrintResult("точка находится в четверти"+res);