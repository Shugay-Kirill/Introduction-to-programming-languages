// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить ,
//  является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, 
//  значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

double[] Input()
{
    string[] parameter = { "a", "b", "c" };
    double[] InputArray = new double[3];

    for (int i = 0; i < InputArray.Length; i++)
    {
        Console.Write($"Введите сторону {parameter[i]} = ");

        while (!double.TryParse(Console.ReadLine()!, out InputArray[i]))
        {
            Console.WriteLine("Неверный ввод");
            Console.Write($"Введите сторону {parameter[i]} = ");
        }
    }
    Console.WriteLine();

    return InputArray;
}

bool CheckTriangle(double[] array)
{
    bool check = true;
    if (array[0] > array[1] + array[2]) check = false;
    if (array[1] > array[0] + array[2]) check = false;
    if (array[2] > array[1] + array[0]) check = false;
    return check;
}

void calculation(double[] array)
{

    double perimeter = array[0] + array[1] + array[2];
    double area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - array[0]) * (perimeter / 2 - array[1]) * (perimeter / 2 - array[2]));
    double corner_ab = Math.Round(Math.Acos((array[0] * array[0] + array[1] * array[1] - array[2] * array[2]) / (2 * array[0] * array[1])) * 180 / Math.PI, 2);
    double corner_ac = Math.Round(Math.Acos((array[0] * array[0] + array[2] * array[2] - array[1] * array[1]) / (2 * array[0] * array[2])) * 180 / Math.PI, 2);
    double corner_bc = Math.Round(Math.Acos((array[2] * array[2] + array[1] * array[1] - array[0] * array[0]) / (2 * array[2] * array[1])) * 180 / Math.PI, 2);

    Console.WriteLine($"Периметр = {perimeter}");
    Console.WriteLine($"Площадь = {area}");
    Console.WriteLine($"Угол между сторонами (a;b) = {corner_ab} (Градусы)");
    Console.WriteLine($"Угол между сторонами (a;c) = {corner_ac} (Градусы)");
    Console.WriteLine($"Угол между сторонами (b;c) = {corner_bc} (Градусы)");

    // double MaxSide = array[0];
    double temp;
    for (int i = 0; i < 2; i++)
    {
        if (array[i] > array[i+1])
        {
            temp = array[i+1];
            array[i+1] = array[i];
            array[i] = temp;
        }
    }
    if (array[0] == array[1] && array[2] == array[1]) Console.WriteLine("Треугольник равносторонний");
    else if (array[0] == array[1] || array[0] == array[2] || array[1] == array[2]) Console.WriteLine("Треугольник равнобедренный");
    else if (array[2] * array[2] == array[1] * array[1] + array[0] * array[0]) Console.WriteLine("Треугольник прямоугольный");
    else Console.WriteLine("Треугольник разносторонний");
}

double [] array = Input();

bool check = CheckTriangle(array);
if (check == true) 
    calculation(array);
else
    Console.WriteLine("Треугольника не существует");
