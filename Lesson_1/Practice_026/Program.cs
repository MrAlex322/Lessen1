// Задайте значение N. Напишите программу, которая выведет все четные
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Numbers(int N)
{
    if (N == 0) return;
        Numbers(N - 1);
        if (N % 2 == 0 && N < 10)
        {
        Console.Write($"{N } ");
        }
}

Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());
Numbers(num);
