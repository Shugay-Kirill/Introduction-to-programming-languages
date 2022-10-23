// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int entryNumber()
{
    int number = 0;
    while (number < 9999 || number > 100000)
    {
        Console.Write("Введите пятизначное число = ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

void checkNumber(int number)
{
    int[] array = new int[5];
    for (int count = 0; count < 5; count++)
    {
        array[4 - count] = number % 10;
        number = number / 10;
    }
    if (array[0] == array[4] && array[1] == array[3])
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

checkNumber(entryNumber());


