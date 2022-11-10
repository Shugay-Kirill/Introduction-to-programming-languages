// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double inputNumberA()
{
    double NumberA;
    Console.Write("Введите число, которое будет возводиться в степень: ");

    while ((!double.TryParse(Console.ReadLine()!, out NumberA)))
    {
        Console.WriteLine("Ошибка при вводе. Повторите ввод числа, которое будет возводиться в степень: ");
    }

    return NumberA;
}
int inputNumberB()
{
    int NumberB;
    Console.Write("Введите целочисленное число, в какую степень возводиться число: ");

    while ((!int.TryParse(Console.ReadLine()!, out NumberB)))
    {
        Console.WriteLine("Ошибка при вводе. Повторите ввод целочисленного числа, в какую степень возводиться число: ");
    }

    return NumberB;
}

void CalculationNumber(double NumberA, int NumberB)
{
    
    Console.WriteLine("Результат = " + (Math.Round(Math.Pow(NumberA, NumberB), 2)));
}
double NumberA = inputNumberA();
int NumberB = inputNumberB();
CalculationNumber(NumberA, NumberB);
