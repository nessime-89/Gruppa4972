// Задача №0
// программа выдает квадрат исходного числа

Console.WriteLine("Введите число");
//считываем данные с консоли
string? inputNum = Console.ReadLine();
//проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
    //парсим введенное число
//    int num = int.Parse(inputNum);
    //находим квадрат числа
//    int res = num*num;
    //выводим данные в консоль
//    Console.WriteLine(res);

    Console.WriteLine("Квадрат числа: "+(int)Math.Pow(int.Parse(inputNum),2));
}


