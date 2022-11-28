// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ведите число");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int num2 = int.Parse(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
