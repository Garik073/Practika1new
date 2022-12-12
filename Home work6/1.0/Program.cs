void MassivK (int chislo)
{
    
    
    int count =0;
    
    int[] mArray = new int [chislo]; // Количество элементов массива
    for (int i = 0; i < mArray.Length; i++)
    {
        Console.Write ($"Введите элемент массива{i}: ");
        mArray[i] = Convert.ToInt32(Console.ReadLine());
        if (mArray[i] > 0) count++;
        
    }
    Console.WriteLine(String.Empty);

     Console.Write("[ ");
    for (int i = 0; i < mArray.Length; i++)
    {
        Console.Write(mArray[i] + " ");
    }
    Console.Write("]");
    Console.Write($"Количество элементов больше 0 = {count}");
    
    
}
   Console.Write("Введите количесство элементов массива: ");
    int a = int.Parse(Console.ReadLine());
    MassivK(a);