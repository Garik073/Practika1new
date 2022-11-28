void Chet(int N)
{
   int i = 0;
   double pere;
   while (i < N )
   {
        i ++;
        pere = Math.Pow(i,3); 
        Console.Write($"{pere},");
    
}
}
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);

