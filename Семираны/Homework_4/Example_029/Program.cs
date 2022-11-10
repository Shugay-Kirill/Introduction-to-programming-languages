//Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] inputArray()
{
    int index = 8;
    int [] arrayNumbers = new int[index];
    int number;
   
    for(int count = 0; count < arrayNumbers.Length; count++)
    {
        Console.Write($"Введите {count} элемент массива (целочисленное число) = ");
        while (!int.TryParse(Console.ReadLine()!, out number))
            {
                Console.Write($"Ошибка при вводе. Повторите ввод. Введите {count} элемент массива (целочисленное число) = ");
            }
        arrayNumbers[count] = number;
    }
    
    return arrayNumbers;
}

void printArray(int[] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        Console.Write($"{arrayNumbers[i]} , ");
    }
}

printArray(inputArray());
