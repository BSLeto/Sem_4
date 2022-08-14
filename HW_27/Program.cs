Console.Clear();

//===============================
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//===============================

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;
while (number > 0)
{
    sum += number%10;
    number /= 10;

    i++;
}
Console.Write($"{sum} ");