//________________________________________________________________________________________________________________________

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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





void SortMassive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < i; k++)
            {
                if(array[i,j] > array[i + 1,j])
                {
                    int temp = array[i + 1,j];
                    array[i + 1,j] = array[i,j];
                    array[i,j] = temp;
                }


            }
        }
    Console.WriteLine();

}




int[,] newArray = RandomArray2d();
Show2Darray(newArray);
SortMassive(newArray);
Show2Darray(newArray);





//________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
















// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.




// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.




// Написать программу поэлементного копирования массива.

//________________________________________________________________________________________________________________________

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// void ChangeRows(int [,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row1 < array.GetLength(0) && row1 != row2)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
// }

// int[,] newArray = RandomArray2d();
// Show2Darray(newArray);
// ChangeRows(newArray, 0, 8);
// Show2Darray(newArray);

//________________________________________________________________________________________________________________________