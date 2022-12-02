void MassivK (int chislo)
{
    
    Console.Write("Введите количесство элементов массива: ");
    int elemetsCount = int.Parse(Console.ReadLine());
    
    int[] mArray = new int [elemetsCount]; // Количество элементов массива
    for (int i = 0; i < mArray.Length; i++)
    {
        Console.Write ($"Введите элемент массива{i}: ");
        mArray[i] = int.Parse(Console.ReadLine());
        
    }
    Console.WriteLine(String.Empty);

    for (int i = 0; i < mArray.Length; i++)
    {
        Console.WriteLine($"Вывод элемента массива mArray, {i}");
        Console.WriteLine(mArray[i]);
    }
    
    
}
    int arg = 0;
    
    MassivK(arg);
