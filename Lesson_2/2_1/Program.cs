﻿
int TakeNum(int num)
{
    Console.WriteLine(num);
    int result1=num % 10;
    int result2=num % 10;
    if (result1>result2)
    {
        return result1;
    }
    else

    {
        return result2;

    }
}
 int itog=TakeNum(new Random().Next(10,100));
 Console.WriteLine(itog);