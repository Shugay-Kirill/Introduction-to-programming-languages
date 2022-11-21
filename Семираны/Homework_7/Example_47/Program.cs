// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    Random random = new Random();

    double[,] array = new double[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() + random.Next(-100,100), 2);
        }
    }

    return array;
}

void PrintArray(double[,] input) {
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write("; ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива = ");
int m;
while(!int.TryParse(Console.ReadLine()!, out m))
{
    Console.WriteLine("Ошибка ввода ");
    Console.Write("Введите количество строк массива = ");
}
    
Console.Write("Введите количество столбов массива = ");

int n;
while(!int.TryParse(Console.ReadLine()!, out n))
{
    Console.WriteLine("Ошибка ввода ");
    Console.Write("Введите количество строк массива = ");
}

var array = CreateArray(m, n);
PrintArray(array);