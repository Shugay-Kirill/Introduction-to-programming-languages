// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

void entryProgram()
{
    Console.Write("Введите N = ");
    int N = int.Parse(Console.ReadLine()!);

    int[] DotA = new int[N];
    int[] DotB = new int[N];
    for (int count = 0; count < N; count++)
    {
        Console.Write($"Введите {count + 1} координату для первой точки = ");
        DotA[count] = int.Parse(Console.ReadLine()!);
    }

    for (int count = 0; count < N; count++)
    {
        Console.Write($"Введите {count + 1} координату для второй точки = ");
        DotB[count] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine(straightLength(DotA, DotB, N));

}

double straightLength(int[] DotA, int[] DotB, int N)
{
    double summ = 0;
    for (int count = 0; count < N; count++)
    {
        summ = summ + Math.Pow(DotA[count] - DotB[count], 2);
    }
    return Math.Round(Math.Sqrt(summ), 2);
}

entryProgram();
