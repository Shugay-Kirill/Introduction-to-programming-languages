// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n 
// (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс, среднее арифметическое. Вывести эту информацию на экран.

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(-99, 100);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 9) Console.Write($" | {array[i, j]}|");
            if (array[i, j] >= 0 && array[i, j] <= 9) Console.Write($" |  {array[i, j]}|");
            if (array[i, j] < 0 && array[i, j] >= -9) Console.Write($" | {array[i, j]}|");
            if (array[i, j] < -9) Console.Write($" |{array[i, j]}|");
        }
        Console.WriteLine();
    }
}

void Сalculation(int[,] array)
{
    double[] result = new double[5];
    int Max = array[0, 0];
    int Min = array[0, 0];
    int[] IndexMax = new int[2];
    int[] IndexMin = new int[2];
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (Max < array[i, j])
            {
                Max = array[i, j];
                IndexMax[0] = i;
                IndexMax[1] = j;
            }
            if (Min > array[i, j])
            {
                Min = array[i, j];
                IndexMin[0] = i;
                IndexMin[1] = j;
            }
            average = +array[i, j];
        }
    }
    Console.WriteLine($"Масимальное число = {Max}");
    Console.WriteLine($"Индекс максимального числа = [{IndexMax[0] + 1};{IndexMax[1] + 1}]");
    Console.WriteLine($"Минимальное число = {Min}");
    Console.WriteLine($"Индекс минимального числа = [{IndexMin[0] + 1};{IndexMin[1] + 1}]");
    Console.WriteLine($"Среднее арифметическо = {Math.Round((average) / (array.GetLength(0) * array.GetLength(1)), 2)}");
}

int n;
int m;

Console.Write("Введите количество строк = ");
while (!int.TryParse(Console.ReadLine()!, out m))
{
    Console.WriteLine("Ошибка ввода данных");
    Console.Write("Введите количество строк = ");
}

Console.Write("Введите количество столбов = ");
while (!int.TryParse(Console.ReadLine()!, out n))
{
    Console.WriteLine("Ошибка ввода данных");
    Console.Write("Введите количество столбов = ");
}

int[,] array = RandomArray(m, n);
Print(array);

Сalculation(array);