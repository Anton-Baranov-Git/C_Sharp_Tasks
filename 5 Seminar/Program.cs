// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] MassiveNumber(int length) // объявляем метод
// {
//     int[] newArray = new int[length]; // создаем массив
//     int minValue = 100; // задаем нижний передел массива
//     int maxValue = 999; // задаем верхний передел массива

//     for(int i = 0; i < length; i++) // объявляем цикл
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1); // генерируем псевдослучайнные числа
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

// Console.Write("Введите размер массива: "); // спрашиваем длину массива
// int size = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// int[] myArray = (MassiveNumber(size)); // записываем массив в переменную


// ShowArray(myArray); // показываем большой массив

// int FindEvenNumbers(int[] array) // создаем метод поиска четных  чисел
// {
//     int count = 0; // создаем переменную счетчика
//     for(int i = 0; i < array.Length; i++) // объявляем цикл
//     {
//         if(array[i] % 2 == 0)count++; // объявляем условие если число четное
//     }
//     return count; // возвращаем все четные числа
// }

// Console.WriteLine($"Количество четных чисел в массиве {FindEvenNumbers(myArray)}");

// if(FindEvenNumbers(myArray) > myArray.Length / 2) Console.WriteLine($"Количество четных чисел больше, чем нечетных на '{FindEvenNumbers(myArray) - (myArray.Length / 2)}' чисел(число, числа)");
// else Console.WriteLine($"Количество четных чисел меньше, чем нечетных на '{(myArray.Length / 2) - FindEvenNumbers(myArray)}' чисел(число, числа)");

//__________________________________________________________________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] MassiveNumber(int length, int minValue, int maxValue) // объявляем метод
// {
//     int[] newArray = new int[length]; // создаем массив

//     for(int i = 0; i < length; i++) // объявляем цикл
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1); генерируем псевдослучайное число и записываем его в ячейку
//     }
//     return newArray; // возвращаем массив
// }

// void ShowArray(int[] array) // объявляем метод
// {
//     Console.Write($"Массив: ");  // пишем что это массив
//     for(int i = 0; i < array.Length; i++) // цикл перебора
//     {
//         if(i == array.Length - 1) Console.Write(array[i]); // последняя строка без запятой
//         else Console.Write(array[i] + ", "); // объявляем цикл
//     }
//     Console.WriteLine(); // пустая строка
// }

// Console.Write("Введите размер массива: "); // спрашиваем длину массива
// int size = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // с чего начианется массив
// int min =Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// Console.Write("Максимальное значение массива: "); // чем заканчивается массив
// int max = Convert.ToInt32(Console.ReadLine()); // записываем в переменную

// int[] myArray = (MassiveNumber(size, min, max)); // записываем массив в переменную


// ShowArray(myArray); // показываем большой массив

// int SumOddPosition(int[] array) // объявляем метод
// {
//     int sum = 0; // переменная суммы
//     for(int i = 1; i < array.Length; i += 2) // объявляем цикл начинается с 1 индекса + 2 шаг
//     {
//         sum = array[i] + sum; // считаем сумму 
//     }
//     return sum; // возвращаем сумму
// }

// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: '{SumOddPosition(myArray)}'"); // выводим результат

//__________________________________________________________________________________________________________________________________________

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] MassiveNumber(int length, int minValue, int maxValue) // объявляем метод
// {
//     double[] newArray = new double[length]; // создаем массив

//     for(int i = 0; i < length; i++) // объявляем цикл
//     {
         
//         double number_1 = new Random().Next(minValue, maxValue + 1); // создаем переменную и записываем в нее псевдослучайное число
//         double number_2 = Math.Round(new Random().NextDouble(), 1); // создаем переменную и записываем в нее псевдослучайное вещественное число
//         newArray[i] = number_1 + number_2; // складываем числа
//     }
//     return newArray; // возвращаем массив
// }
// void ShowArray(double[] array) // объявляем метод
// {
//     Console.Write($"Массив: "); // пишем что это массив
//     for(int i = 0; i < array.Length; i++) // цикл перебора
//     {
//         if(i == array.Length - 1) Console.Write(array[i]); // последняя строка без запятой
//         else Console.Write(array[i] + "| "); // объявляем цикл
//     }
//     Console.WriteLine(); // пустая строка
// }

// Console.Write("Введите размер массива: "); // спрашиваем длину массива
// int size = Convert.ToInt32(Console.ReadLine()); // записываем в переменную длину массива

// Console.Write("Минимальное значение массива: "); // спрашиваем минимальное значение массива
// int min =Convert.ToInt32(Console.ReadLine()); // записываем в переменную 

// Console.Write("Максимальное значение массива: "); // спрашиваем максимальное значение массива
// int max = Convert.ToInt32(Console.ReadLine()); // записываем в переменную 

// double[] myArray = (MassiveNumber(size, min, max)); // записываем массив в переменную


// ShowArray(myArray); // показываем большой массив


// double MinMaxDif(double[] array) // создаем метод 
// {
//     double minNumber = array[0]; // объявляем предположительное минимально число
//     double maxNumber = array[0]; // объявляем предположительное максимальное число
//     double difference = 0; // объявляем предположительную разницу
//     for(int i = 0; i < array.Length; i++) // запускаем цикл
//     {
//         if(array[i] > maxNumber) maxNumber = array[i]; // Если число больше максимального, нашли новое число
//         if(array[i] < minNumber) minNumber = array[i]; // Если число меньше минимального, нашли новое число
//     }
//     difference = maxNumber - minNumber; // получаем разницу
//     return difference; // возвращаем
// }

// Console.WriteLine($"Разница между максимальным и минимальным эллементом массива равна - '{Math.Round(MinMaxDif(myArray),2)}'"); // выводим ответ


//__________________________________________________________________________________________________________________________________________
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

// Console.Write("Введите размер массива: ");
// int size =Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимальное значение массива: ");
// int min =Convert.ToInt32(Console.ReadLine());

// Console.Write("Максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] myArray = (MassiveNumber(size, min, max));


// int[] Revers(int [] array)
// {
//     int[] myArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         myArray[i] = array[i] * (-1);
//     }
//     return myArray;
// }

// int[]revers = Revers(myArray);
// ShowArray(myArray);
// ShowArray(revers);

//__________________________________________________________________________________________________________________________________________

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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


// bool BoolNumber(int[] array, int number)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (number == array[i])
//         {
//             return true;
//         }
//     }
//      return false;
// }

// Console.Write("Введите размер массива: ");
// int size =Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимальное значение массива: ");
// int min =Convert.ToInt32(Console.ReadLine());

// Console.Write("Максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Веедите число которое ищем в массиве: ");
// int MyNumber = Convert.ToInt32(Console.ReadLine());


// int[] myArray = (MassiveNumber(size, min, max));

// ShowArray(MassiveNumber(size, min, max));
// bool change = BoolNumber(myArray, MyNumber);

// if (change == true) Console.Write("Данное число присутствует в массиве");
// else Console.Write("Данное число не присутствует в массиве");



//__________________________________________________________________________________________________________________________________________

// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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

// Console.Write("Введите размер массива: ");
// int size =Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимальное значение массива: ");
// int min =Convert.ToInt32(Console.ReadLine());

// Console.Write("Максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] myArray = (MassiveNumber(size, min, max));


// ShowArray(myArray);

// int FindNumberElements(int[] array)
// {
//     int index = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 10 && array[i] < 100)
//         {
//             index++;
//         }
//     }
//     return index;
// }


// Console.Write($"Количество двухзначных чисел в массиве: {FindNumberElements(myArray)}");

//__________________________________________________________________________________________________________________________________________


