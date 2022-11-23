// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }
    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

int minIndexString (int[,] array)
{
    int min = 0;
    int minIndex = 0;
    int summ = 0;
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            summ =+ array[i,j];
        }

        if(i == 0) min = summ;
        if (min > summ) 
        {
            min = summ;
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array = CreateArray(3,4);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minIndexString(array) + 1} строка ");