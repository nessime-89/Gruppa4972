// №21 
//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//* Сделать метод загрузки точек

// введение переменных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}

//вычисление
double Calc3DDist(int x1,int x2,int y1,int y2,int z1,int z2)
{
    double res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
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
int z1=ReadData("Введите координату z1: ");
int z2=ReadData("Введите координату z2: ");

double res=Calc3DDist(x1,x2,y1,y2,z1,z2);
PrintResult("Расстояние между точками равняется:"+ $"{res}");