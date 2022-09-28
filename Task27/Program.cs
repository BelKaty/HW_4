// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write ("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int result = 0;
while (Number > 0)
{
    result = result + Number % 10;
    Number = Number / 10;
}

Console.WriteLine($"Сумма цифр числа: {result}");