//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Программа принимает на вход три числа и выдаёт максимальное из этих чисел");

Console.Write("Введите первое число = ");
int number_1 = int.Parse(Console.ReadLine()!);

int max = number_1;

Console.Write("Введите второе число = ");
int number_2 = int.Parse(Console.ReadLine()!);

if (number_2 > number_1) max = number_2;

Console.Write("Введите третье число = ");
int number_3 = int.Parse(Console.ReadLine()!);

if (number_3 > max) max = number_3;

Console.WriteLine("Максимальное число = " + max);