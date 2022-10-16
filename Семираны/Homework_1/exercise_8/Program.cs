//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите натуральное число N = ");
int N = int.Parse(Console.ReadLine()!);

if (N < 1) Console.WriteLine("Введено не натуральное число");

int count = 2;
while (count < N + 1)
{
    Console.Write(count + ", ");
    count = count + 2;
}
if (N == 1) Console.WriteLine("На промежутке нет четных чисел");