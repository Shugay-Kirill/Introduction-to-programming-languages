// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayWithRandomNumber(int startInterval, int endInterval, int LengthArray)
{
    int[] array = new int[LengthArray];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startInterval, endInterval);
    }
    return array;
}

int SummOddNumbers(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }

    return summ;
}

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);

        if (i != input.Length - 1)
            Console.Write(", ");
    }

    Console.WriteLine();
}

Console.Write("Введите длинну массива = ");
int LengthArray;
while (!int.TryParse(Console.ReadLine()!, out LengthArray))
{
    Console.Write("Ошибка при вводе. Введите длинну массива =");
}
int[] array = CreateArrayWithRandomNumber(-100, 100, LengthArray);
Print(array);
Console.WriteLine($"Сумма элементов находя = {SummOddNumbers(array)}");
