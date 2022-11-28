Console.WriteLine("Введите число: ");
string number = Console.ReadLine(); // Масиив
int a = number.Length; // Длина массива

if (a == 5)
{
    if (number[0] == number[4] && number[1] == number[3]) // Проверяет массив на совпадения. Массив всегда ничинаеться с 0.
                                                          //Поэтому проверяем чтобы ячеки 0 и 4 соподали позначению так же и с ячеками 1 и 3
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным"); // в вели больше 5 чисел что не соответсвует условиям
}
