﻿
void NumRendom()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"{num} - >{num/ 100}{num % 10}");
}
NumRendom();
