﻿// Домашнее задание

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation() // объявляем метод int например на входе num_a = 3, num_b = 4
// {
//     int result = 0; // создаем переменную result
//     int current = 1; // создаем переменную current

//     Console.Write("Введите число 'А': "); // запрашиваем число
//     int num_a = Convert.ToInt32(Console.ReadLine()); // записываем число в переменную

//     Console.Write("Введите число 'B': "); //запрашиваем число
//     int num_b = Convert.ToInt32(Console.ReadLine()); // записываем число в переменную

//     if (num_a <= 0 ^ num_b <= 0) // если любая из чисел меньше 0
//     {
//         Console.WriteLine($"Неправильный ввод, числа меньше '0'"); // предупреждение
//     }
//     for(int i = 1; i <= num_b; i++) // объявляем цикл for
//     {
//         current = (num_a * current); // считаем, 3 * 1 = 3
//         result = current * num_a; // считаем, 1 * 3 = 3
//     }
//     return result; // возвращаем результат
// }

// void ExponentiationShow(int num) // создаем метод
// {
//     if(num > 0) // если на входе больше нуля, выводим результат
//     {
//         Console.WriteLine($"Результат возведения в степень равен: {num}"); // выводим результат
//     }
//     }

// while(true) // бесконечно заставляем вводить циферки
// {
//     ExponentiationShow(Exponentiation()); // запускаем методы
//     Console.WriteLine("И еще раз..."); // выводим сообщение о новой итерации
// }


//_____________________________________________________________________________________________________________________________


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SummNumber()
// {
//     int result = 0;
//     Console.Write("Введите число: "); // запрашиваем число
//     int number = Convert.ToInt32(Console.ReadLine()); // записываем число в переменную
//     for(int i = 0; number != i; number /= 10) // объявляем условие for
//     {
//         result = result + number % 10; // отделяем и суммируем последнюю цифру
//     }
//     if(result < 0) // если результат меньше 0
//     {
//         result *= (-1); // меняем знак на противополжный
//     }
//     return result; // возвращаем результат
// }
// Console.WriteLine($"Сумма чисел равна: {SummNumber()}"); // выводим результат

// void SummNumberShow(int num) // создаем метод
// {
//         Console.WriteLine($"Сумма цифр в числе равна: {num}"); // выводим результат
// }


// while(true) // бесконечно заставляем вводить циферки
// {
//     SummNumberShow(SummNumber()); // запускаем методы
//     Console.WriteLine("И еще раз..."); // выводим сообщение о новой итерации
// }

//_____________________________________________________________________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] MassiveIputNumber() // объявляем метод
// {
//     Console.Write($"Сколько чисел будет в массиве: "); // запрашиваем количество чисел
//     int length = Convert.ToInt32(Console.ReadLine()); // записываем в переменную
//     int[] newarray = new int[length]; // создаем массив
//     int index = 1; // создаем переменную для запроса чисел
//     Console.WriteLine($"Вам нужно ввести {length} числа (чисел)"); // сообщение о запросе чисел;

//     for(int i = 0; i < length; i++) // объявляем цикл
//     {
//         Console.Write($"Введите число {index}:  "); // какое число вводим сейчас
//         newarray[i] = Convert.ToInt32(Console.ReadLine()); // записываем число в массив
//         index++; // двигаем счетчик
//     }
//     return newarray; // возвращаем массив
// }

// void ShowArray(int[] array) // объявляем метод
// {
//     Console.Write($"Получился массив из {array.Length} чисел(числа):  "); // выводим сообщение
//     for(int i = 0; i < array.Length; i++) // цикл перебора
//     {
//         if(i == array.Length - 1) Console.Write(array[i]); // последняя строка без запятой
//         else Console.Write(array[i] + ", "); // объявляем цикл
//     }
//     Console.WriteLine(); // пустая строка
// }

// ShowArray(MassiveIputNumber()); // запускаем методы

// _____________________________________________________________________________________________________________________________
