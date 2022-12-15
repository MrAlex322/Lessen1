// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i] = new Random().Next(100, 1000);
        if (matr[i] % 2 == 0)
        {
            Console.WriteLine(matr[i]);
        }
    }
}

int[] matrix = new int[3];
Array(matrix);
Console.WriteLine();
FillArray(matrix);
