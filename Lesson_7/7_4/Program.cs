﻿
void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)

    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random(). Next(from, to);

    return arr;
}
int SumMass(int[,] array)
{
    int sumarray=0;
    for(int i=0; i<array.GetLength(0); i++)
    
        for(int j=0; j<array.GetLength(1); j++)
        {
           if(i==j)sumarray=sumarray+array[i,j];
        }
        return sumarray;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int num_start = int.Parse(Console.ReadLine()!);
int num_stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, num_start, num_stop);
Print(mass);
int sum= SumMass(mass);
Console.WriteLine($"Summa:{sum}");

