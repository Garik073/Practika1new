void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int [] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-30,30);
    return arr;
}

void Search(int[] arr)
{
    int Summ = 0;
    int Odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            Odd = arr[i];
            Summ += Odd;
        }
    }
   Console.WriteLine($"Сумма всех нечетных элементов {Summ}");
    
}

int[] arr_1 = Mass(Convert.ToInt32(Console.ReadLine()));
Print(arr_1);
Search(arr_1);
