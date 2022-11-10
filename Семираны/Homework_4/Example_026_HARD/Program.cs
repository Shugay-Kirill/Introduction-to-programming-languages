// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3

// 82 -> 2

// 9,012 ->4

double[] InputNumber()
{
    Console.Write("Введите число = ");
    string number = Console.ReadLine();
    double resultNumber;

    while (double.TryParse(number, out resultNumber) == false)
    {
        Console.Write("Ошибка ввода. Введите число = ");
        number = Console.ReadLine();
    }

    double lengthNumber = number.Length;
    double[] array = new double[2];
    array[0] = resultNumber;
    array[1] = lengthNumber;
    return (array);
}

double NumberOfDigits(double[] array)
{
    double resultNumber = Math.Abs(array[0]);
    double lengthNumber = array[1];
    double result = 0;
    int count = 0;
    if (array[0] < 0) lengthNumber --;
    double wholePart = Math.Truncate(resultNumber);

    while (wholePart > 0)
    {
        wholePart = Math.Truncate(wholePart) / 10;
        count++;
    }
    count--;

    if (count == lengthNumber) result = lengthNumber;
    else result = lengthNumber -1;

    return result;
}

void PrintResult(double result)
{
    Console.WriteLine($"Результат вычислений = {result}");
}

void main()
{

    double result = NumberOfDigits(InputNumber());
    PrintResult(result);
}

main();

// Сумма цифр в дробном или целом числе
// double[] InputNumber()
// {
//     Console.Write("Введите число = ");
//     string number = Console.ReadLine();
//     double resultNumber;

//     while (double.TryParse(number, out resultNumber) == false)
//     {
//         Console.Write("Ошибка ввода. Введите число = ");
//         number = Console.ReadLine();
//     }

//     double lengthNumber = number.Length;
//     double[] array = new double[2];
//     array[0] = resultNumber;
//     array[1] = lengthNumber;
//     return (array);
// }

// double NumberOfDigits(double[] array)
// {
//     double resultNumber = array[0];
//     double lengthNumber = array[1];
//     double result = 0;
//     double lengthWholeNumber = 0;
//     int count = 0;
//     double wholePart = Math.Truncate(resultNumber);

//     while (wholePart > 0)
//     {
//         wholePart = Math.Truncate(wholePart) / 10;
//         count++;
//     }
    
//     double number = resultNumber * Math.Pow(10, lengthNumber - count);

//     for(int i = 0; i < lengthNumber -1; i++)
//     {
//         result = result + number % 10;
//         result = Math.Truncate(result);
//         number /=10;
//     }
    
//     return result;
// }

// void PrintResult(double result)
// {
//     Console.WriteLine($"Результат вычислений = {result}");
// }

// void main()
// {

//     double result = NumberOfDigits(InputNumber());
//     PrintResult(result);
// }

// main();


