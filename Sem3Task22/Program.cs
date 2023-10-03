// Задача №22

//Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//Например:
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4


// введение переменных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
double Calc2DDist(int x1,int x2,int y1,int y2)
{
    double res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return res;
}
    // Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}

int x1=ReadData("Введите координату Х1: ");
int x2=ReadData("Введите координату Х2: ");
int y1=ReadData("Введите координату Y1: ");
int y2=ReadData("Введите координату Y2: ");

double res=Calc2DDist(x1,x2,y1,y2);
PrintResult("Расстояние между точками равняется:"+ $"{res}");