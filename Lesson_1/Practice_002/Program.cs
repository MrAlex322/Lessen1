//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write ("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write ("Введите число c: ");
int c = int.Parse(Console.ReadLine());
if (a > b)
{
    if ( a > c)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(c);
    }
}
else 
{
   if ( b > c)
    {
        Console.Write(b);
    }
    else
    {
        Console.Write(c);
    } 
}