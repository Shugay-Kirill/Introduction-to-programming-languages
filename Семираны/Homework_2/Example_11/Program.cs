// Задача 11 HARD - необязательная: 
// Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.


int entryNumber()
{
    int number;
    Console.Write("Введите число большее 9 = ");
    bool check = false;

    while ((!int.TryParse(Console.ReadLine()!, out number)))
    {
        Console.Write("Введите число большее 9 = ");
    }
    while (check == false)
    {
        if  (number > 9)
            check = true;
        else 
        {
            Console.Write("Введите число большее 9 = ");
            while ((!int.TryParse(Console.ReadLine()!, out number)))
                Console.Write("Введите число большее 9 = ");
        }
    }
    return number;
}

void thirdDigi(int number)
{
    int divide = number;
    int lengthNumber = 0;

    while (divide > 0)
    {
        divide = divide / 10;
        lengthNumber++;
    }

    Console.WriteLine("Число без второй цифры = " + ((number / ((int)Math.Pow(10, (lengthNumber - 1)))) * ((int)Math.Pow(10, (lengthNumber - 2))) +
        (number % ((int)Math.Pow(10, (lengthNumber - 2))))) + "; Исходное число = " + number);
}
int number = entryNumber();
thirdDigi(number);

