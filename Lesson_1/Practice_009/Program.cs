// ДЗ. Задание_1 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("ВВедите число ");
    int num = int.Parse(Console.ReadLine());
    if (num % 10000 == num)
    Console.WriteLine("Error");
        else if (num / 1000 == num % 100)
    Console.WriteLine("yes");
        else 
    Console.WriteLine("no");
