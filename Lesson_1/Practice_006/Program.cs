// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Number = new Random().Next(100, 1000);
Console.WriteLine(Number);
int num1 = Number / 100;
int num2 = Number % 10;
Console.Write(num1);
Console.Write(num2);