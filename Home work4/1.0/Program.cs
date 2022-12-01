//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Chet( int A,int B)
{
    int summa = A;
  
  for (int i = 1;i < B; i++)
  {
    summa = summa * A;
  }
  Console.Write($" Сумма в степени числа В {summa}");
    
}

Console.WriteLine("Введите число A");
int ChisloA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int ChisloB = int.Parse(Console.ReadLine());
Chet(ChisloA,ChisloB);
