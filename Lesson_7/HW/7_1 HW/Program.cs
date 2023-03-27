
void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)

    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j], 6}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr=new double[row,column];
    Random n_new=new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(n_new.NextDouble()* -10, 2);

    return arr;
}
Console.Write("Enter the number of rows:");
    

int row_num= int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns:");
int column_num = int.Parse(Console.ReadLine()!);
int num_start = int.Parse(Console.ReadLine()!);
int num_stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num, num_start, num_stop);
Print(mass);
