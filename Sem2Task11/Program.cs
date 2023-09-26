// Задача №11

//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа. 

// сгенерировать число и вывести его на экран
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
//найти 1 и 3 число
    int first = number / 100;
    int last = number % 10;
// сложить 1 число и 3 число
    number = first*10 + last;
    Console.WriteLine(number);