// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите число ");
int SecondNumber = int.Parse(Console.ReadLine());
if ( SecondNumber / 100 == 0)
{
    Console.WriteLine("Неверное число, введите трехзначное число");
}
else
{
    Console.WriteLine ((SecondNumber % 100)/10);
}