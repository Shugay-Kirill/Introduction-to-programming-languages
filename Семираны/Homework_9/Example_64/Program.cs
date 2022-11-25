// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumber (int number = 8)
{
    string result = string.Empty;
    if(number == 0) return result;
    if(number == 1) return result + number + PrintNumber(number-1);
    return result + number +", " + PrintNumber(number-1);
}

Console.WriteLine(PrintNumber());