// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int entryNumber()
{
    int number;
    Console.Write("Введите цифру дня недели = ");
    
    while ((!int.TryParse(Console.ReadLine()!, out number)))
    {
        Console.Write("Введите цифру дня недели = ");
    }
    
    bool check = false;
    
    while (check == false)
    {
        if  ((number > 0) && (number < 8))
            check = true;
        else 
        {
            Console.Write("Введите цифру дня недели = ");
            while ((!int.TryParse(Console.ReadLine()!, out number)))
                Console.Write("Введите цифру дня недели = ");
        }
    }
    return number;
}

void dayOff(int number)
{
    if (number == 6 || number == 7)
        Console.WriteLine("Выходной день");
    else
        Console.WriteLine("Не выходной день");
}

int number = entryNumber();
dayOff(number);
