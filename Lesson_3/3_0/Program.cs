
void Quarters(int x,int y)
{
    if(x==0 || y==0)
    Console.WriteLine("x=0,y=0");
    else if(x>0 && y>0)
    Console.WriteLine("i");
    else if(x<0 && y>0)
    Console.WriteLine("ii");
    else if(x<0 && y<0)
    Console.WriteLine("iii");
    else if(x>0 && y<0)
    Console.WriteLine("iv");
}
int num1=int.Parse(Console.ReadLine()!);
int num2=int.Parse(Console.ReadLine()!);
Quarters(num1, num2);