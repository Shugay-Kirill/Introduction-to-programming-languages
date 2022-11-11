// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayWithRandomNumber(int startInterval, int endInterval, int LengthArray)
{
    int[] array = new int[LengthArray];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startInterval,endInterval);
    }
    return array;
}
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    return count;
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
while(!int.TryParse(Console.ReadLine()!, out LengthArray))
{
    Console.Write("Ошибка при вводе. Введите длинну массива =");
}
int [] array = CreateArrayWithRandomNumber(100,1000,LengthArray);
Print(array);
Console.WriteLine($"Количество четных чисел в массиве = {CountEvenNumbers(array)}");
