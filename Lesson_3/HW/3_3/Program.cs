﻿
void Squares(int n)
{
    double[] nums=new double[n];
    int index=0;
    Console.Write($"{n} - >");
    while(index<n)
    {
        nums[index] = Math.Pow((index+1), 3);
        Console.Write($"{nums[index]},");
        index += 1;
    }
    Console.WriteLine();
}
Squares(int.Parse(Console.ReadLine()!));