// // Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке..
// // Далее надо посчитать количество нулей и единиц,
// // если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

bool checkArray()
{
    int[] array = new int[8];
    int countOne = 0;
    int countNull = 0;
    Random random = new Random();
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = random.Next(0, 2);
        if (array[count] == 0) countNull++;
        if (array[count] == 1) countOne++;
    }
    bool check = false;
    if (countOne > countNull) check = true;
    return check;
}

Console.WriteLine(checkArray());



///////////////////////////////////////////////////////
// int [] ArrayNumber()
// {
//     int [] array = new int[8];
//     Random random = new Random();
//     for (int count = 0; count < array.Length; count++)
//     {
//         array[count] = random.Next(0,2);
//     }
//     return array;
// }
// bool countNullAndUnits(int [] array)
// {

//     int countNull = 0;
//     int countUnits = 0;
//     for(int i = 0; i < 8; i++)
//     {
//         if(array[i] == 0) countNull++;
//         if(array[i] == 1) countUnits++;
//         Console.WriteLine($" - {i}");
//         Console.WriteLine("countUnits= "+countUnits);
//         Console.WriteLine("countNull= "+countNull);
//     }
//     Console.WriteLine("countUnits= "+countUnits);
//     Console.WriteLine("countNull= "+countNull);
//     bool check = false;
//     if (countUnits > countNull) check = true;
//     return check;
// }
// void PrintArray(int [] array)
// {
//     Console.WriteLine("Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.");
//     for (int count = 0; count < array.Length; count++)
//     {
//         Console.Write($"{array[count]}, ");
//     }
// }

// int [] array = ArrayNumber();

// PrintArray(array);

// Console.WriteLine(countNullAndUnits(array));





