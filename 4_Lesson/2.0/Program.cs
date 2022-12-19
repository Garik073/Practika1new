// Напишите программу которая принимает число на вход число и выдает количество цифр в числе
int NumCount(int n)
{
    if (n == 0)
    {
        return 1;
    }
    int i = 0;
    while (n > 0)
    {
        n = n / 10;
        i++;

    }
    return i;

}
Console.WriteLine(NumCount(int.Parse(Console.ReadLine())));






