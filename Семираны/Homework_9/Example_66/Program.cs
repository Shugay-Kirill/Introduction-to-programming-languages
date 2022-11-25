// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNumber(int M = 4, int N = 8)
{
    int summ =+ M;
    if (M == N) return summ;
    return summ  + SummNumber(M + 1, N);
}
Console.WriteLine($"summ = {SummNumber()}");