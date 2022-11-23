// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateArray(int length, int width, int height)
{
    var random = new Random();
    int[,,] array = new int[length, width, height];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(-100, 101);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            for(var k = 0; k < input.GetLength(2);k++)
            {
                Console.Write($"{input[i,j,k]} ({i};{j};{k}); ");
            }
            Console.WriteLine();
        }
        
    }
}

var array = CreateArray(2,2,2);
PrintArray(array);