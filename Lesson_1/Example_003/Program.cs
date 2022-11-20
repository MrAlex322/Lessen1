Console.Write ("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
while (!int.TryParse(Console.ReadLine("Введите число a: "), out a))
    Console.Write("Неверный ввод! \nВведите число а: ");
    Console.Write ("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

if ( a > b)
{
    Console.Write("Ошибка, число b должно быть больше числа a");
}
else
{
    int sum = 0;
    while (a < b)
    { if ( a % 2 == 0)
        {
            sum = sum + a;
             a++;
        }
    else
        {
            a++;
        }
    }
    Console.Write(sum);
}
