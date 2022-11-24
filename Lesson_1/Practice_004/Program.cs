// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 1;
if ( a <= 0)
    Console.Write("Ведите натуральное число"); 
else if ( a == b)
{
   Console.Write("Числа в интервале отсутсвуют"); 
}
else while (b <= a)
{
    if ( b % 2 == 0)
    {
        Console.Write(b);
        Console.Write(";");
        b++;
    }
    else
    {
        b++;
    }
}