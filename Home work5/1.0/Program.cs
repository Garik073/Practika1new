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
        arr[i] = new Random().Next(100,999);
    return arr;
}

void Search(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
             even++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: = {even}");
}

int[] arr_1 = Mass(Convert.ToInt32(Console.ReadLine()));
Print(arr_1);
Search(arr_1);


