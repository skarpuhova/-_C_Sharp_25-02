﻿
double Line3D(double x1,double y1,
double z1,double x2,double y2,double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)
    + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
}
double x_1=double.Parse(Console.ReadLine()!);
double y_1=double.Parse(Console.ReadLine()!);
double z_1=double.Parse(Console.ReadLine()!);
double x_2=double.Parse(Console.ReadLine()!);
double y_2=double.Parse(Console.ReadLine()!);
double z_2=double.Parse(Console.ReadLine()!);
Console.WriteLine(Line3D(x_1,y_1,z_1,x_2,y_2,z_2));