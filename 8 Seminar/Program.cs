//________________________________________________________________________________________________________________________
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

// int[,] RandomArray2d() // данный метод создает 2D массив
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

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array) // данный метод показывает 2D массив
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

// void SortMassive(int[,] array) // данный метод сортирует 2D массив по строкам
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             {
//                 for (int j = 0; j < array.GetLength(0) - 1; j++)
//                 {
//                     if (array[i,j] < array[i,j + 1])
//                         {
//                             int temp = array[i,j];
//                             array[i,j] = array[i,j + 1];
//                             array[i,j + 1] = temp;
//                         }
//                 }
            
//             }
//         }
//     Console.WriteLine();
// }

// int[,] newArray = RandomArray2d(); // применяем метод 2D массива
// Show2Darray(newArray); // показываем новый массив
// SortMassive(newArray); // сортируем массив
// Show2Darray(newArray); // показываем отсортированный массив

//________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

// int[,] RandomArray2d() // данный метод создает 2D массив
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

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2Darray(int[,] array) // данный метод показывает 2D массив
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {   
//         int sum = 0;
//         Console.Write($"{i} строка: ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
            
//             Console.Write(array[i, j] + " ");
//             sum = array[i, j] + sum;
//         }
//         Console.Write($" Сумма данной строки: {sum}");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MinimalSumRows(int[,] array) // данный метод складывает значения массива и показывает наименьшее
// {
//     int rows = 0;
//     int min = 0; 
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         min = array[0, i] + min;
//     }   

//     for(int k = 0; k < array.GetLength(0); k++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//         sum = array[k,j] + sum;
//         }
//     if(sum < min)
//     {
//         min = sum;
//         rows = k;
//     }
//     }
//     Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rows}");
// }

// int[,] newArray = RandomArray2d(); // применяем метод 2D массива
// Show2Darray(newArray); // показываем новый массив
// MinimalSumRows(newArray);

//________________________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Размер массива m: "); // спрашиваем длину массива
// int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Размер массива n: "); // спрашиваем длину массива
// int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int minValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int maxValue = Convert.ToInt32(Console.ReadLine()); // записываем в переменную



// int[,] RandomArray2d(int rows, int columns, int minValue, int maxValue) // данный метод создает 2D массив
// {

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

// void Show2Darray(int[,] array) // данный метод показывает 2D массив
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

// int[,] first_Array = RandomArray2d(rows,columns,minValue,maxValue); // применяем метод 2D массива
// int[,] second_Array = RandomArray2d(rows,columns,minValue,maxValue); // применяем метод 2D массива
// Console.WriteLine();

// int[,] MatrixMultiplication (int [,] array_1, int[,] array_2)
// {
//     int[,] MatrixArray = new int[array_1.GetLength(0), array_1.GetLength(1)];
//     if (array_1.GetLength(0) != array_2.GetLength(1)) Console.Write("Матрицы разные, невозможно перемножить");
//     else
//     {
//         for (int i = 0; i < array_1.GetLength(0); i++)
//             for (int j = 0; j < array_1.GetLength(1); j++)
//                 for (int k = 0; k < array_1.GetLength(1); k++)
//                     {
//                         MatrixArray[i,j] += array_1[i,k] * array_2[k,j];
//                     }
//     }
//     return MatrixArray;
// }


// Show2Darray(first_Array);
// Show2Darray(second_Array);
// int[,] Mat_Array = MatrixMultiplication(first_Array, second_Array);
// Show2Darray(Mat_Array);


//________________________________________________________________________________________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// int[,,] RandomArray3dNoRepeat() // данный метод создает 3D массив
// {
//     Console.Write("Размер массива x: "); // спрашиваем длину массива
//     int rows = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     Console.Write("Размер массива y: "); // спрашиваем длину массива
//     int columns = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     Console.Write("Размер массива z: "); // спрашиваем длину массива
//     int diagonal = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

//     int[,,] newArray = new int[rows, columns, diagonal];
//     int count = -99; // минимальное двузначное число

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             for(int k = 0; k < diagonal; k++)
//             {
//                 if(count > -10 && count < 10) // только двухзначные :)
//                     {
//                         count = 10;
//                     }

//                 newArray[i, j, k] = count;
//                 count += 1;

//             }

//     return newArray;
// }

// void Show3Darray(int[,,] array) // данный метод показывает 3D массив
// {
//     int switched = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if(switched == 1) break;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             Console.WriteLine();
//             if(switched == 1) break;
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] > 99)
//                 {
//                     if(switched == 1) break;
//                     switched = 1;
//                     Console.WriteLine("Все числа закончились, аларм, все взорвалось");
//                 }
//                 else Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }


// int[,,] My_Array = RandomArray3dNoRepeat();
// Show3Darray(My_Array);



//________________________________________________________________________________________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Решение частичтно списано из плюсов, часть логики из пайтон взял, сборная солянка, есть вещи которые
// не совсем понимаю как работаю, но они работают. 

// void Show2Darray(int[,] array) // данный метод показывает 2D массив
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

//     int len = 4;
//     int[,] NewArray = new int[len, len];

// void SpiralArray(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// SpiralArray(NewArray, len);
// Show2Darray(NewArray);
//________________________________________________________________________________________________________________________

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