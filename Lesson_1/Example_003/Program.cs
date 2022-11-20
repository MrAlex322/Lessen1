int a = 1, b = 15;
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