﻿
void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();
}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 1; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}
int OddNumSum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i+=2)
        count+=arr[i];

    return count;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(OddNumSum(mass));

