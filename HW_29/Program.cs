Console.Clear();
// 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetBinaryArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);

    }
    return result;
}
Console.Write($"Введите необходимую длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите минимальное значение в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимальное значение в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] testArray = GetBinaryArray(number, min, max);
Console.WriteLine($"Результат: [{String.Join(", ", testArray)}]");


