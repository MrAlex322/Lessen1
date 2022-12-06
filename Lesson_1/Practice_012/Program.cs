// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B. Без модуля Math, используем цикл for.

void Sum(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
    result = A * result;
    }
    Console.WriteLine(result);
}

Sum(4, 3);
