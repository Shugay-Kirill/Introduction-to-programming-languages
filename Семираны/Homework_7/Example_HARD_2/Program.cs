// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) ,
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый ГАРАНТИРОВАННО переместился на другое место и выполнить это за m*n / 2 итераций. И после этого чтоб каждый уже перемещенный элемент не трогали.
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

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

int[,] MixArray(int[,] input)
{
    int[,] mixArray = new int[input.GetLength(0), input.GetLength(1)];
    var random = new Random();
    int countM = 0;
    int countN = 0;
    for (int i = 0; i < input.Length / 2; i++)
    {
        while (mixArray[countM, countN] != 0)
        {
            if (countN +1 < input.GetLength(1)) countN++;
            else
            {
                countM++;
                countN = 0;
            }
        }

        int randomN = random.Next(countN, input.GetLength(1));
        int randomM = random.Next(countM, input.GetLength(0));
        if ((randomN == countN && randomM == countM) || mixArray[randomM, randomN] != 0 )
        {
            bool check = false;
            while (check == false)
            {
                if ((randomN != countN || randomM != countM) && (mixArray[randomM, randomN] == 0)) check = true;
                else 
                {
                    randomN = random.Next(0 , input.GetLength(1));
                    randomM = random.Next(0 , input.GetLength(0));
                }
            }
        }
        mixArray[countM, countN] = input[randomM, randomN];
        mixArray[randomM, randomN] = input[countM, countN];

    }
    return mixArray;
}

int m = 1;
int n = 1;
while (m * n % 2 != 0)
{
    Console.WriteLine("Введите размер массив, чтобы размерность была четная");
    Console.Write("Введите количество строк массива = ");

    while (!int.TryParse(Console.ReadLine()!, out m))
    {
        Console.WriteLine("Ошибка ввода ");
        Console.Write("Введите количество строк массива = ");
    }

    Console.Write("Введите количество столбов массива = ");

    while (!int.TryParse(Console.ReadLine()!, out n))
    {
        Console.WriteLine("Ошибка ввода ");
        Console.Write("Введите количество строк массива = ");
    }
}
int[,] array = CreateArray(m, n);
int[,] mixArray = MixArray(array);

PrintArray(array);
Console.WriteLine();
PrintArray(mixArray);

