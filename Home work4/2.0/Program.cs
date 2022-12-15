void Chet2 (int Chislo)
{
    int result = 0;
    while (Chislo > 0)
    {
       result += Chislo % 10;
       Chislo = Chislo /10;

    }
    Console.WriteLine($" Общая сумма введенного числа {result}");
    
} 

Console.WriteLine("Введите число: ");
int Chislod = int.Parse(Console.ReadLine()); 
Chet2(Chislod);
