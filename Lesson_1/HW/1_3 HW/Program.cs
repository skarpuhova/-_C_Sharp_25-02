
Console.Write("Введите целое число больше 1:");
int inputNum = int.Parse(Console.ReadLine()!);
int count = 2;
while(count <= inputNum)
{
Console.Write($"{count}");
count = count + 2;
if (count <= inputNum)
Console.Write(", ");
}
