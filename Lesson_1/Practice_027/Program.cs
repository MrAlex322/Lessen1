// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

int Sum(int m, int n)
{
    if (m > n)
        return 0;
        return Sum (m + 1, n) + m;
}

Console.WriteLine(Sum(1, 15));
