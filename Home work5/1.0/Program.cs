void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100,999);
    return arr;
}

void Poisk(int[] arr)
{
    int Chetnoe = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
             Chetnoe++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: = {Chetnoe}");
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Poisk(arr_1);


