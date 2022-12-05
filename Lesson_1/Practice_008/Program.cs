// Напишите программу, которая принимает на вход цифру,обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите число от 1 до 7 ");
int Number = int.Parse(Console.ReadLine());
if ( Number <= 0|Number > 7 )
{
    Console.WriteLine("Введите корректное число");
}
else if (Number < 6)
    {
        Console.WriteLine ("нет");
    }
    else
    {
        Console.WriteLine ("да");
    }