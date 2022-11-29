// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

int number(int num)
{   
    Console.WriteLine(num);
    return num % 10;
}

Console.WriteLine(Number(new Random().Next(100, 1000)));
