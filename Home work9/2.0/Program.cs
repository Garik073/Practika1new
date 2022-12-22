Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());


void SumNumbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbers(numberM, numberN, sum);
}

SumNumbers(numberM, numberN, 0);
