// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

ulong functionAkkermane(ulong m = 3, ulong n = 3)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return functionAkkermane(m-1,1);
    return functionAkkermane(m-1,functionAkkermane(m,n-1));
}
Console.WriteLine(functionAkkermane());