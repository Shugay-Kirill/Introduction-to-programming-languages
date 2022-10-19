// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int entryNumber()
{
    int number;
    Console.Write("Введите трехзначное число = ");
    
    while ((!int.TryParse(Console.ReadLine()!, out number)))
    {
        Console.Write("Введите трехзначное число = ");
    }

    bool check = false;
    
    while (check == false)
    {
        if  ((number > 99) && (number < 1000))
            check = true;
        else 
        {
            Console.Write("Введите трехзначное число = ");
            while ((!int.TryParse(Console.ReadLine()!, out number)))
                Console.Write("Введите трехзначное число = ");
        }
    }
    return number;
}

int secondDigit(int number)
{
    int result = ((number % 100) / 10);
    return result;
}

int number = entryNumber();
Console.WriteLine("Вторая цифра = " + secondDigit(number) + "; Число = "+ number);