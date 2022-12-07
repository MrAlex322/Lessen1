// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{matr[i]} ");
    }
    Console.WriteLine();
}
void Array(int[] matr)
{
    int sum_i = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i] = new Random().Next(100, 1000);
        if (i % 2 > 0)
        {
            sum_i = sum_i + matr[i];
        }
    }
Console.Write($"{sum_i} -> ");
}

int sum_i = 0;
int[] matrix = new int[5];
Array(matrix);
FillArray(matrix);


