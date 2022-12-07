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
      int min = int.MaxValue;
      int max = int.MinValue;
    
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] <= min)
        {
            min = arr[i];
        }
    }
   Console.WriteLine($"Макимальное значение {max}");
   Console.WriteLine($"Минимальное значение {min}");
   Console.WriteLine($"Разница между Максимальным и минимальным значением {max - min}");
    
}

int[] arr_1 = Mass(Convert.ToInt32(Console.ReadLine()));
Print(arr_1);
Search(arr_1);

