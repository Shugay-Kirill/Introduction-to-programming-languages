// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


void inputArray()
{
    int index = 1;
    int count = 0;
    int [] arrayNumbers = new int[index];
    int number;

    Console.Write($"Введите {index} значение массива (Для завершения ввода данных нажмите на'ENTER') = ");
    string inputNumbers = Console.ReadLine();
    
    while (inputNumbers != "")
    {
        bool check = int.TryParse(inputNumbers, out number);
        
        if (check)
        {
            Array.Resize(ref arrayNumbers, index);
            arrayNumbers [index - 1] = number;
            index++;
            if (number > 0) count++;
        }
        else 
        {
            Console.WriteLine("Неверный ввод");
            Console.WriteLine("Чтобы завершить ввод данные нажмите 'ENTER'");
        }

        Console.Write($"Введите {index} значение массива (Для завершения ввода данных нажмите на'ENTER') = "); 
        inputNumbers = Console.ReadLine();
    }

    Console.WriteLine($"Количество положительных чисел = {count}");
}

inputArray();