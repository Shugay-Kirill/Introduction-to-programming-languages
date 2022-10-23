// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

void checkNumber()
{
    Console.WriteLine("Введите число = ");
    int number = int.Parse(Console.ReadLine()!);
    int changeNumber = number;
    int lengthNumber = 1;

    while (changeNumber > 10)
    {
        changeNumber = changeNumber / 10;
        lengthNumber++;
    }

    int[] array = new int[lengthNumber];
    int changeNumber2 = number;

    for (int count = 0; count < lengthNumber; count++)
    {
        array[lengthNumber - 1 - count] = changeNumber2 % 10;
        changeNumber2 = changeNumber2 / 10;
    }

    bool check = true;
    for (int i = 0; i < (lengthNumber / 2); i++)
    {
        if (array[i] != array[lengthNumber - 1 - i])
            check = false;
    }

    if (check == true)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

checkNumber();

