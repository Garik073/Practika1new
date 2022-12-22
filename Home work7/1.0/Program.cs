//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}


double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Convert.ToDouble (new Random().Next(-50, 50)) / 10;

    return arr;
}

Console.Write("Enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] arr_1 = MassNums(row, column);
Print(arr_1);


