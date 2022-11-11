// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArrayWithRandomNumber(int startInterval, int endInterval, int LengthArray)
{
    double[] array = new double[LengthArray];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(endInterval - random.NextDouble() * startInterval * 2, 2);
    }
    return array;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write("; ");
    }

    Console.WriteLine();
}

double DiffMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    double result = Math.Round(max - min, 2);
    return result;
}

Console.Write("Введите длинну массива = ");
int LengthArray;
while (!int.TryParse(Console.ReadLine()!, out LengthArray))
{
    Console.Write("Ошибка при вводе. Введите длинну массива =");
}
double[] array = CreateArrayWithRandomNumber(-100, 100, LengthArray);
Print(array);
Console.WriteLine($"Разница = {DiffMinMax(array)}");

