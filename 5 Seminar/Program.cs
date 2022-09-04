

// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// int[] MassiveNumber(int length, int minValue, int maxValue) // объявляем метод
// {
//     int[] newArray = new int[length];

//     for(int i = 0; i < length; i++) // объявляем цикл
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray; // возвращаем массив
// }

// void ShowArray(int[] array) // объявляем метод
// {
//     Console.Write($"Массив: ");
//     for(int i = 0; i < array.Length; i++) // цикл перебора
//     {
//         if(i == array.Length - 1) Console.Write(array[i]); // последняя строка без запятой
//         else Console.Write(array[i] + ", "); // объявляем цикл
//     }
//     Console.WriteLine(); // пустая строка
// }

// int FindPositiveSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         sum = sum + array[i];
//     }
//     return sum;
// }

// int FindNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         sum = sum + array[i];
//     }
//     return sum;
// }

// Console.Write("Введите размер массива: ");
// int size =Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимальное значение массива: ");
// int min =Convert.ToInt32(Console.ReadLine());

// Console.Write("Максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] myArray = (MassiveNumber(size, min, max));



// int positiveSum = FindPositiveSum(myArray);
// int negativeSum = FindNegativeSum(myArray);

// ShowArray(myArray);

// Console.Write($"Сумма положительных чисел: {positiveSum} \nСумма отрицательных чисел: {negativeSum}");


//__________________________________________________________________________________________________________________________________________

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.


int[] MassiveNumber(int length, int minValue, int maxValue) // объявляем метод
{
    int[] newArray = new int[length];

    for(int i = 0; i < length; i++) // объявляем цикл
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray; // возвращаем массив
}

void ShowArray(int[] array) // объявляем метод
{
    Console.Write($"Массив: ");
    for(int i = 0; i < array.Length; i++) // цикл перебора
    {
        if(i == array.Length - 1) Console.Write(array[i]); // последняя строка без запятой
        else Console.Write(array[i] + ", "); // объявляем цикл
    }
    Console.WriteLine(); // пустая строка
}

Console.Write("Введите размер массива: ");
int size =Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное значение массива: ");
int min =Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = (MassiveNumber(size, min, max));


int[] Revers(int [] array)
{
    int[] myArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        myArray[i] = array[i] * (-1);
    }
    return myArray;
}

int[]revers = Revers(myArray);
ShowArray(myArray);
ShowArray(revers);

//__________________________________________________________________________________________________________________________________________

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.








//__________________________________________________________________________________________________________________________________________

// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

