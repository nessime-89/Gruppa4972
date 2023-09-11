// Напишите программу, которая будет выдавать название дня недели по заданному номеру

//  задание №3

string [] dayOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine("Введите номер");
int day = int.Parse(Console.ReadLine());

Console.WriteLine(dayOfWeek[day-1]);