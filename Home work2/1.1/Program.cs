int number = ReadInt("Введите трехзначное число: ");
int number2 = number.ToString().Length;

if (number2 < 3 || number2 > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}

