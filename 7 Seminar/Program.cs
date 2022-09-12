// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] RandomArray2dFloat()
// {
//     Console.Write("Размер массива m: "); // спрашиваем длину массива
// int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Размер массива n: "); // спрашиваем длину массива
// int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     double[,] newArray = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             int int_number = new Random().Next(minValue, maxValue + 1);
//             double double_number = new Random().NextDouble();
//             newArray[i, j] = Math.Round((int_number + double_number),2);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("|" + array[i, j] + "|");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] newArray = RandomArray2dFloat();
// Show2Darray(newArray);

//________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.


// int[,] RandomArray2d()
// {
//     Console.Write("Размер массива m: "); // спрашиваем длину массива
// int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Размер массива n: "); // спрашиваем длину массива
// int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void FindValueXY(int[,] array)
// {
//     Console.Write("Введите точку X: "); // спрашиваем длину массива
//     int X_point = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива
//     Console.Write("Введите точку Y: "); // спрашиваем длину массива
//     int Y_point = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     if (X_point > array.GetLength(0) || Y_point > array.GetLength(1))
//         Console.WriteLine($"Значение элемента с кординатами X - '{X_point}' и Y - '{Y_point}' не существует");
//     else Console.WriteLine($"Значение эллемента с кординатами 'X' - {X_point} и 'Y' - {Y_point} - '{array[X_point, Y_point]}'");
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);
// FindValueXY(newArray);

//________________________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] RandomArray2d()
{
    Console.Write("Размер массива m: "); // спрашиваем длину массива
int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

Console.Write("Размер массива n: "); // спрашиваем длину массива
int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

Console.Write("Минимальное значение массива: "); // с чего начианется массив
int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

Console.Write("Максимальное значение массива: "); // чем заканчивается массив
int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2Darray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageColumns(int[,] array)
{
    double[] Array1D = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            Array1D[j] = (Array1D[j] + (array[i,j]));
        }
        Array1D[j] /= array.GetLength(0);
    }
    return Array1D;
}

void ShowArray(double[] array) // объявляем метод
{
    Console.Write($"Массив: ");  // пишем что это массив
    for(int i = 0; i < array.Length; i++) // цикл перебора
    {
        if(i == array.Length - 1) Console.Write(Math.Round((array[i]),2)); // последняя строка без запятой
        else Console.Write(Math.Round(array[i], 2) + "|"); // объявляем цикл
    }
    Console.WriteLine(); // пустая строка
}

int[,] newArray = RandomArray2d();
Show2Darray(newArray);
ShowArray(AverageColumns(newArray));





// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] RandomArray2d()
// {
//     Console.Write("Размер массива m: "); // спрашиваем длину массива
// int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Размер массива n: "); // спрашиваем длину массива
// int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);



// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

// int[,] RandomArray2d()
// {
//     Console.Write("Размер массива m: "); // спрашиваем длину массива
// int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Размер массива n: "); // спрашиваем длину массива
// int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] SumIndexArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);
// Show2Darray(SumIndexArray(newArray));


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int[,] RandomArray2d()
// // {
// //     Console.Write("Размер массива m: "); // спрашиваем длину массива
// // int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// // Console.Write("Размер массива n: "); // спрашиваем длину массива
// // int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// // Console.Write("Минимальное значение массива: "); // с чего начианется массив
// // int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// // Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// // int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// //     int[,] newArray = new int[rows, columns];

// //     for(int i = 0; i < rows; i++)
// //     {
// //         for(int j = 0; j < columns; j++)
// //         {
// //             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
// //         }
// //     }
// //     return newArray;
// // }

// void Show2Darray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] EvenIndexArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i=i+2)
//     {
//         for (int j = 0; j < array.GetLength(1); j=j+2)
//             {
//                 array[i,j] *= array[i,j];
//             }
//     }
//     return array;
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);
// Show2Darray(EvenIndexArray(newArray));



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] RandomArray2d()
// {
//     Console.Write("Размер массива m: "); // спрашиваем длину массива
//     int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     Console.Write("Размер массива n: "); // спрашиваем длину массива
//     int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     Console.Write("Минимальное значение массива: "); // с чего начианется массив
//     int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     Console.Write("Максимальное значение массива: "); // чем заканчивается массив
//     int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int DiagonalSumArray(int[,] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//     {
//         sum += array(i, i);
//     }
//     return sum;
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);

// int a = DiagonalSumArray(newArray);

// Console.WriteLine($"Сумма элементов на диагонали равна: {a}");






//444444
//555555

