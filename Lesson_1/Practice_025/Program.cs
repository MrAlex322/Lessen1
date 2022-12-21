// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(1, 10);
    return arr;
}

int[,] MatrixElements(int[,] arrF, int[,] arrSec)
{
    int row_size = arrF.GetLength(0);
    int column_size = arrF.GetLength(1);
    int[,] matrix = new int[row_size, column_size];

    if (column_size != arrSec.GetLength(0))
        return matrix;
    else if (column_size == arrSec.GetLength(0))
        matrix = new int[row_size, row_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < row_size; j++)
        {
            for (int n = 0; n < column_size; n++)
                matrix[i, j] += arrF[i, n] * arrSec[n, j];
        }
    }
    return matrix;
}

Console.Write("Enter the number of rows 1: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Enter the number of rows 2: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column);
int[,] arr_2 = MassNums(row2, column2);
int[,] arrF = new int[row, column];
int[,] arrSec = new int[row2, column2];
Print(arr_1);
Print(arr_2);
Print(MatrixElements(arr_1, arr_2));
