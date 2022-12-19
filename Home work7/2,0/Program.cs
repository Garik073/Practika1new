// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


void Print(int[,] arr)
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


int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int FindElem(int[,] arr, int a, int b)
{
    
       Console.WriteLine($" Элемент находящийся на этой позиции = {arr[a-1, b-1]}");
       return arr[a-1, b-1];
}

Console.Write("Enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write("Enter Первый элемент позиции массива  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Второй элемент позиции массива: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > row || b > column )

 Console.WriteLine("Такого элемента не существует");
else
{
FindElem(arr_1, a, b);
}


