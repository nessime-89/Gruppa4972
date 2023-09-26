// №10 

//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа. 



    // сгенерировать число и вывести его на экран
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    int first = number / 100;
    int last = number % 10;

    number = first*10 + last;
    Console.WriteLine(number);
