// Задайте массив. Напишите программу, которая определяет: присутствует ли заданное число в массиве.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

string IfInNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])        
            return "Yes";        
    }
    return "No";
}


int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(IfInNum(arr_1, int.Parse(Console.ReadLine())));
