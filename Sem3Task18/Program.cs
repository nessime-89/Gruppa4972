// Задача №18

//Напишите программу, которая по заданному номеру
//четверти, показывает диапазон возможных
//координат точек в этой четверти (x и y).

// введение № четверти
int getQuarter()
{
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}

// //Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

string pointsIdent(int quarterNum)
{
    if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
    if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
    if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
    if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

int quarterNum = getQuarter();
Console.WriteLine(pointsIdent(quarterNum));