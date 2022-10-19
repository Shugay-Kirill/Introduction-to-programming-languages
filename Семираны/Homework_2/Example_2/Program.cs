// Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

int entryNumber()
{
    int number;
    Console.Write("Введите количество людей = ");
    bool check = false;

    while ((!int.TryParse(Console.ReadLine()!, out number)))
    {
        Console.Write("Введите количество людей = ");
    }
    while (check == false)
    {
        if (number > 0)
            check = true;
        else
        {
            Console.Write("Введите количество людей = ");
            while ((!int.TryParse(Console.ReadLine()!, out number)))
                Console.Write("Введите количество людей = ");
        }
    }
    return number;
}

void numberOfPeople(int number)
{
    string programmer = "программист";
    if (number == 1 || number % 10 == 1)
        Console.WriteLine(number + " " + programmer);
    if ((number > 1 && number < 5) || ((number > 20) && (number % 10 > 0 && number % 10 < 5)))
        Console.WriteLine(number + " " + programmer + "а");
    if ((number > 4 && number < 21) || (number % 10 > 4 && number % 10 < 10))
        Console.WriteLine(number + " " + programmer + "ов");
}

int number = entryNumber();
numberOfPeople(number);

// int number = int.Parse(Console.ReadLine()!);
// string programmer = "программист";

// if ((number > 1 && number < 5) || ((number > 20) && (number % 10 > 0 && number % 10 < 5)))
//     Console.WriteLine(number + " " + programmer);