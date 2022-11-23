// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    array[i, j] = i + j + 1;
    int count = 1;
    while (count < array.Length)
    {
        while (j < array.GetLength(1) - 1 && array[i, j + 1] == 0)
        {
            j++;
            array[i, j] = count + 1;
            count++;
        }
        while (i < array.GetLength(0) - 1 && array[i + 1, j] == 0)
        {
            i++;
            array[i, j] = count + 1;
            count++;
        }
        while (j > 0 && array[i, j - 1] == 0)
        {
            j--;
            array[i, j] = count + 1;
            count++;
        }
        while (i > 0 && array[i - 1, j] == 0)
        {
            i--;
            array[i, j] = count + 1;
            count++;
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
            if (input[i, j] < 10) Console.Write("  ");
            if ( input[i,j] > 9 && input[i,j] < 100) Console.Write(" ");
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

var array = SpiralArray(5, 5);
PrintArray(array);