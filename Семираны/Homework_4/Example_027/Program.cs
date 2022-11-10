// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int InputNumber()
{
    int number;
    Console.Write("Введите целочисленное число = ");

    while (!int.TryParse(Console.ReadLine()!, out number))
    {
        Console.Write("Ошибка при вводе. Повторите ввод. Введите целочисленное число = ");
    }
    return number;
}

int NumberOfDigits(int number)
{
    int result = 0;
   
    for (int count = 0 ,remainder; number != 0; count++)
    {
        remainder = number % 10;
        number /= 10;
        result = result + remainder;
    }
    return result;
}

void PrintResult(int result)
{
    Console.WriteLine($"Результат = {result}");
}

void main()
{
    int number = InputNumber();
    int result = NumberOfDigits(number);
    PrintResult(result);
}

main();
