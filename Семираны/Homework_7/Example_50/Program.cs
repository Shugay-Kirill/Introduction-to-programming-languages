// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string Search(int[,] input, int number)
{

    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (input[i, j] == number)
            {
                return $"Число {number} имеет индекс = [{i + 1},{j + 1}]";
            }
        }
    }
    return "Такого числа нет в массиве";
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

Console.Write("Число для поиска = ");
int number;
while (!int.TryParse(Console.ReadLine()!, out number))
{
    Console.WriteLine("Ошибка ввода ");
    Console.Write("Число для поиска = ");
}

Console.WriteLine(Search(array, number));