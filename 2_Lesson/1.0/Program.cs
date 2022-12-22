// 0. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNum(int num)
{
    Console.WriteLine(num);
    int num_max = 0;
    
    while (num > 0)
    {
        if (num % 10 > num_max)
        {
            num_max = num % 10;
        }
        num = num / 10; 
    }
    return num_max;
}

Console.WriteLine(MaxNum(new Random().Next(10, 100)));