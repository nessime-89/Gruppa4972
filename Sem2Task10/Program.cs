// №10 

//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа. 

// сгенерировать число и вывести его на экран
int num = new System.Random().Next(100, 1000);
System.Console.WriteLine(num);

// перевод в строку и вывод 2го числа
char[] digitChar = num.ToString().ToCharArray();
System.Console.Write(digitChar[1]);





    
