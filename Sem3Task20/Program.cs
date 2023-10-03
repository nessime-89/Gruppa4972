// Задача №20

//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между
//ними в 2D пространстве.
//Например:
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


// введение переменных
int ReadDate(double msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//по координатам точки определяем № четверти
double Calc2Dist (double x1, double y1, double x2, double y2)
{
    double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return res;
}

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
