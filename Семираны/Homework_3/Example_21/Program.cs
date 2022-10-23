// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void entryProgram()
{
    int[] DotA = new int[3];
    int[] DotB = new int[3];
    for (int count = 0; count < 3; count++)
    {
        Console.Write($"Введите {count + 1} координату для первой точки = ");
        DotA[count] = int.Parse(Console.ReadLine()!);
    }

    for (int count = 0; count < 3; count++)
    {
        Console.Write($"Введите {count + 1} координату для второй точки = ");
        DotB[count] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine(straightLength(DotA, DotB));

}

double straightLength(int[] DotA, int[] DotB)
{
    return Math.Round(Math.Sqrt(Math.Pow(DotA[0] - DotB[0], 2) + Math.Pow(DotA[1] - DotB[1], 2) + Math.Pow(DotA[2] - DotB[2], 2)), 2);
}

entryProgram();
