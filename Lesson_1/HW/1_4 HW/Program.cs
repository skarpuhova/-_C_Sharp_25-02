
void Find(int num)
{
if (num % 2 == 0)
Console.WriteLine("Да");
else Console.WriteLine("Нет");
}

Console.Write("Введите число для проверки на четность:");
Find(int.Parse(Console.ReadLine()!));
