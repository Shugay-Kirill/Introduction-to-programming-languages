// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string Average(int[,] input)
{
    double[] acerage = new double[input.GetLength(1)];
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            acerage[j] += input[i, j];
        }
    }
    string result = "";
    for (var i = 0; i < acerage.GetLength(0); i++)
    {
        acerage[i] /= input.GetLength(0);
        result += $"{acerage[i]}";
        if (i != acerage.GetLength(0))
            result += "; ";
    }
    return result;
}

Console.Write("Введите количество строк массива = ");
int m;
while (!int.TryParse(Console.ReadLine()!, out m))
{
    Console.WriteLine("Ошибка ввода ");
    Console.Write("Введите количество строк массива = ");
}

Console.Write("Введите количество столбов массива = ");
int n;
while (!int.TryParse(Console.ReadLine()!, out n))
{
    Console.WriteLine("Ошибка ввода ");
    Console.Write("Введите количество строк массива = ");
}

var array = CreateArray(m, n);
PrintArray(array);

Console.WriteLine($"Среднее арифметическое каждого столба = [ {Average(array)}]");