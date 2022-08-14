Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Write($"Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= B; i++)
// {
//     result *= A;
// }
// Console.WriteLine(result);
//===============================
// Console.Write($"Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int sum = 0;
// while (number > 0)
// {
//     sum += number%10;
//     number /= 10;

//     i++;
// }
// Console.Write($"{sum} ");
//================================================================================================================================
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
//------------------------------------------------------------------------------------------------
//1. for
// Console.WriteLine($"Введите число A");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= number; i++)
// {
//     result+=i;


// }
// Console.WriteLine($"Сумма элементов от 1 до {number} равна = {result}");
//================================================================================================================================

//2. Через метод и цикл while
// Метод  - собственная функция.
// PascalCase for MethodName
// Console.Write($"Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int GetSumNumbers(int number)
// {
//     int sum = 0;
//     int start = 1;
//     while (start <= number)
//     {
//         sum += start;
//         start++;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма элементов от 1 до {A} равна = {GetSumNumbers(A)}");
//================================================================================================================================

// 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.Write($"Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Convert.ToString(number).Length}");
//----------------------
// Console.Write($"Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while (number > 0)
// {
//     number /= 10;

//     i++;
// }
// Console.Write($"{i} ");
// //================================================================================================================================

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write($"Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// for (int i = 2; i <= number; i++)
// {
//     factorial *= i; 
// }
// Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
// //================================================================================================================================

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);
        // Console.Write($"{result[i]} ");
    }
    return result;
}
Console.Write($"Введите необходимую длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] testArray = GetBinaryArray(number);
Console.WriteLine($"Результат: [{String.Join(", ", testArray)}]");




