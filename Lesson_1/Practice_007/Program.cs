// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число ");
int SecondNumber = int.Parse(Console.ReadLine());
if ( SecondNumber / 100 == 0)
{
    Console.WriteLine("Третьего числа нету");
}
else
{
    Console.WriteLine (SecondNumber % 10);
}
