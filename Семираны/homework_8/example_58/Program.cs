// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    Console.WriteLine();
}

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int count;
    for (int i = 0; i < result.GetLength(0); i++)
    {

        for (int j = 0; j < result.GetLength(1); j++)
        {
            count = 0;
            while (count < array1.GetLength(1))
            {
                result[i, j] = result[i, j] + array1[i, count] * array2[count, j];
                count++;
            }
        }
    }
    return result;
}


var array1 = CreateArray(2, 2);
var array2 = CreateArray(2, 2);
PrintArray(array1);

PrintArray(array2);
if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] newArray = MatrixProduct(array1, array2);
    PrintArray(newArray);
}
else
    Console.WriteLine("Error. n1 != m2");
