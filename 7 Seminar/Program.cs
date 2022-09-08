









// Доделать последнюю задачу















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

