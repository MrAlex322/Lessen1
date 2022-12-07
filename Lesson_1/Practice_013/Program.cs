// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Num(int n)
{
    int sum = 0;
    while (n / 10 > 1)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine(sum+n);
}

Num(6);
