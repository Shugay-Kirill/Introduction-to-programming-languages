// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Input()
{
    string[] parameter = { "b1", "k1", "b2", "k2" };
    double[] InputArray = new double[4];

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Введите {parameter[i]} = ");

        while (!double.TryParse(Console.ReadLine()!, out InputArray[i]))
        {
            Console.WriteLine("Неверный ввод");
            Console.Write($"Введите {parameter[i]} = ");
        }
    }
    Console.WriteLine();

    return InputArray;
}

double[] IntersectionPoint(double[] array)
{

    double[] coordinates = new double[2];
    coordinates[0] = (array[2] - array[0]) / (array[1] - array[3]);
    coordinates[1] = array[1] * coordinates[0] + array[0];

    return coordinates;
}

double[] array = Input();

double[] coordinates = IntersectionPoint(array);

Console.WriteLine($"Точка пересечение = [{Math.Round(coordinates[0], 2)};{Math.Round(coordinates[1], 2)}]");