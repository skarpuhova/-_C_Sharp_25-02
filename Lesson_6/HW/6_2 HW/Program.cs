
void Intersection(double r1, double b1, double r2, double b2)
{
    double k_sub=r1-r2;
    if(k_sub !=0)
    {
        double x=(b2-b1)/(r1-r2);
        double y=r1*x+b1;
        Console.WriteLine($"Intersection point: ({x}; {y})");
    }
    else if(r1==r2 && b1==b2)
    Console.WriteLine("There are an infinite number of intersection points.");
    else
     Console.WriteLine("There is no intersection point");
}
double r1=double.Parse(Console.ReadLine()!);