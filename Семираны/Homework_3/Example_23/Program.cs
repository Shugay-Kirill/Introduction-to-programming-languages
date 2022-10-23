// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




int entryNumber()
{
    int number = 0;
    while (number <= 0)
    {
        Console.Write("Введите натурльное число N = ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

void cubeOfNumbers(int number)
{
    
    int count = 1;
    while (count < number)
    {
        Console.Write($"{Math.Pow(count,3)}, ");
        count++;
    }
}

cubeOfNumbers(entryNumber());
//entryNumber();