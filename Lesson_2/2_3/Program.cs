
void Find(int num)
{
    if(num % 7==0 && num % 23==0)
    Console.WriteLine("да");
    else Console.WriteLine("нет");
}
Find(int.Parse(Console.ReadLine()!));

