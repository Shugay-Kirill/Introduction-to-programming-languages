// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int entryNumber()
// {
//     Console.Write("Введите число = ");
//     int number;

//     while (!int.TryParse(Console.ReadLine()!, out number))
//         Console.WriteLine("Введите число = ");
//     return number;
// }

// void thirdDigi(int number)
// {
//     int result = number;
//     int lengthNumber = 0;

//     while (result > 0)
//     {
//         result = result / 10;
//         lengthNumber++;
//     }
//     if (lengthNumber - 3 >= 0)
//     {
//         Console.WriteLine("Третья цифра = " + ((number / ((int)Math.Pow(10, (lengthNumber - 3)))) % 10) + "; Число = " + number);
//     }
//     else
//         Console.WriteLine("Третьей цифры нет");
// }
// int number = entryNumber();
// thirdDigi(number);



//Второй вариант решения(быстрее и меньше на 2 строки)
int entryNumber()
{
    Console.Write("Введите число = ");
    int number;

    while (!int.TryParse(Console.ReadLine()!, out number))
        Console.Write("Введите число = ");
    return number;
}

void thirdDigi(int number)
{
    if ((number / 100) != 0)
    {
        int result = number;
        while (result > 1000)
        {
            result = result / 10;
        }
        Console.WriteLine("Третья цифра = " + ((result % 10) + "; Число = " + number));
    }
    else
        Console.WriteLine("Третьей цифры нет");
}
int number = entryNumber();
thirdDigi(number);