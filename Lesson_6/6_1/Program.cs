﻿
string convert(int num_1)
{
    string result="";
    while(num_1>0)
    {
        result=num_1 % 2 + result;
        num_1=num_1/2;
    }
    return result;
}
Console.WriteLine(convert(12));
