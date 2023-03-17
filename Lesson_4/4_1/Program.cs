
int SumNum(int num)
{
    int kol=0;
    for(int i=0; num > 0;i++)
 {
    num = num/10;
    kol = 1;
 }
return kol;
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(A));