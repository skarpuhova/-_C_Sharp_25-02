
void exploer(int int1,int int2)
{
    if(int1 % int2==0)
      Console.WriteLine("кратно");
    else
      Console.WriteLine($"не кратно {int1 % int2}");
}
exploer(16,4);