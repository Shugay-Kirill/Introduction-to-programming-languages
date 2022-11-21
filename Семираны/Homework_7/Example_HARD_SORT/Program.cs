// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-50, 51);
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

int[,] SortArray(int[,] input)
{
    int i;
    int j;
    int temp;
    for (int count = 0; count < input.Length ; count++)
    {
        for (i = 0; i < input.GetLength(0); i++)
        {
            for (j = 0; j < input.GetLength(1) - 1; j++)
            {
                if (input[i, j] > input[i, j + 1])
                {
                    temp = input[i, j];
                    input[i, j] = input[i, j + 1];
                    input[i, j + 1] = temp;
                }
            }
            if ((i != input.GetLength(0) -1) && (input[i, j] > input[i + 1, 0]))
            {
                temp = input[i, j];
                input[i, j] = input[i + 1, 0];
                input[i + 1, 0] = temp;
            }
        }
    }

    return input;
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

Console.WriteLine("Сортированный массив");
var newArray = SortArray(array);
PrintArray(newArray);

