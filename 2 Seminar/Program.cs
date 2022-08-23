// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void SecondNumber(int number) // объявляем метод
// {
//     if(number < 100 ^ number > 999) // если число не трехзначное
//     {
//         Console.WriteLine($"Введенное число {number} не является трехзначным"); // то пишем ответ
//     }
//     else // если все ок
//     {
//         int length_number = number % 100 / 10; // первое действие получае 2 цифры после сотни, второе действие убираем последнюю цифру
//         Console.WriteLine($"Вторая цифра числа {number} является {length_number}"); // показываем результат
//     }
// }

// Console.Write("Введите трехначное число: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя трехзначное число

// SecondNumber(num_1); // запускаем метод


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Решение через массивы и преобразование строки

void Find_3_Number(int number) // объявляем метод
{
    string number_text = Convert.ToString(number); // идем на stackoverflow и подсматриваем как int превратить в string
    if(number_text.Length > 2) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number_text[2]}\""); // если знаков больше 2 в числе печатаем ответ
    else Console.WriteLine($"Число \"{number}\" не имеет третьей цифры"); // если знаков меньше двух, печатаем другой ответ
}
Console.Write("Введите число: "); // запрашиваем число
int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число

Find_3_Number(num_1); // запускаем метод

// Решение без преобразования строки
// void Find_3_Number(long number) // объявляем метод, дальше не собираюсь комментировать это безумие :)
// {
//     if(number > 2147483647 ^ number < -2147483648)Console.WriteLine($"Введенное число \"{number}\" должно быть в пределах от \"-2147483648\" до \"2147483647\"");
//     if(number >= 999999999 & number < 2147483647) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10000000 % 10}\"");
//     if(number >= 99999999 & number < 999999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 1000000 % 10}\"");
//     if(number >= 9999999 & number < 99999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 100000 % 10}\"");
//     if(number >= 999999 & number < 9999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10000 % 10}\"");
//     if(number >= 99999 & number < 999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 1000 % 10}\"");
//     if(number >= 9999 & number < 99999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 100 % 10}\"");
//     if(number >= 999 & number < 9999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10 % 10}\"");
//     if(number >= 100 & number < 999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number % 10}\"");
//     if(number < 100 ^ number < -100) Console.WriteLine($"Число \"{number}\" не имеет третьей цифры");
//     if(number <= -100 & number > -999) Console.WriteLine($"Третья Цифра числа \"{number}\" является \"{number % 10 * (-1)}\"");
//     if(number <= -999 & number > -9999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10 % 10 * (-1)}\"");
//     if(number <= -9999 & number > -99999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 100 % 10 * (-1)}\"");
//     if(number <= -99999 & number > -999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 1000 % 10 * (-1)}\"");
//     if(number <= -999999 & number > -9999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10000 % 10 * (-1)}\"");
//     if(number <= -9999999 & number > -99999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 100000 % 10 * (-1)}\"");
//     if(number <= -99999999 & number > -999999999) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 1000000 % 10 * (-1)}\"");
//     if(number <= -999999999 & number < -2147483648) Console.WriteLine($"Третья цифра числа \"{number}\" является \"{number / 10000000 % 10}\"");
// }
// Console.Write("Введите число: "); // запрашиваем число
// long num_1 = Convert.ToInt64(Console.ReadLine()); // получаем от пользователя число

// Find_3_Number(num_1); // запускаем метод


// 3 способ без массива

void Find_3_Number(int number) // объявляем метод
{
    int length_number = 0; // создаем переменную длина числа
    int number_1 = number; // копируем переменную для вычисления длины числа
    int res = 0; // создаем переменную для результата

    while(number_1 > 0 ^ number_1 < 0) // цикл подсчета разряда
    {
        number_1 = number_1 / 10; // делим на 10 получая разряд
        length_number = length_number + 1; // счетчик
    }
    if(length_number > 2) // если больше 2 символов...
    {
        int step_1 = Convert.ToInt32(Math.Pow(10, length_number - 2)); // возведение в степень (питонячий ** не сработал)
        int step_2 = Convert.ToInt32(Math.Pow(10, length_number - 3)); // возведение в степень (питонячий ** не сработал)
        res = number % step_1 / step_2; // убираем лишние знаки
        if(res < 0) res = res * (-1); // в случае ввода отрицательного числа меняем знак на +

        Console.WriteLine($"Третья цифра числа \"{number}\" является \"{res}\""); // Печатаем ответ
    }
    else
    {
        Console.WriteLine($"Число \"{number}\" не имеет третьей цифры"); // Печатаем ответ если меньше 2 цифр в числе
    }

}
Console.Write("Введите число: "); // запрашиваем число
int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число

Find_3_Number(num_1); // запускаем метод


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Решение без объявления дней

// void FindNumberWeek(int number) // объявляем метод
// {
//     if(number < 1 ^ number > 7) Console.WriteLine($"Введенное число {number} меньше одного или больше семи, введите число от 1 до 7");
//     if(number >= 6 & number < 8)Console.WriteLine("Данный день является выходным");
//     if(number >= 1 & number <= 5)Console.WriteLine("Данный день не является выходным");
// }
// Console.Write("Введите число от одного до семи: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число от 1 до 7

// FindNumberWeek(num_1); // запускаем метод


// Решение с объявлением дней
// void FindNumberWeek(int number) // объявляем метод
// {
//     if(number < 1 ^ number > 7) Console.WriteLine($"Введенное число {number} меньше одного или больше семи, введите число от 1 до 7"); // делаем проверку, если число меньше 1 или больше 7
//     if(number == 1) Console.WriteLine($"Вы ввели число {number} - это понедельник и он не является выходным"); // проверяем
//     if(number == 2) Console.WriteLine($"Вы ввели число {number} - это вторник и он не является выходным"); // проверяем
//     if(number == 3) Console.WriteLine($"Вы ввели число {number} - это среда и он не является выходным"); // проверяем
//     if(number == 4) Console.WriteLine($"Вы ввели число {number} - это четверг и он не является выходным"); // проверяем
//     if(number == 5) Console.WriteLine($"Вы ввели число {number} - это пятница и он не является выходным"); // проверяем
//     if(number == 6) Console.WriteLine($"Вы ввели число {number} - это суббота и он является выходным"); // проверяем
//     if(number == 7) Console.WriteLine($"Вы ввели число {number} - это воскресенье и он является выходным"); // проверяем
// }
// Console.Write("Введите число от одного до семи: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число от 1 до 7

// FindNumberWeek(num_1); // запускаем метод




// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Find_Number_Max(int number)
// {
//     int edin = number % 10;
//     int desyat = number / 10;

//     int max;
//     if(edin > desyat) max = edin;
//     else max = desyat;

//     return max;
// }

// int Random_number = new Random().Next(10, 100);
// int BigNumber = Find_Number_Max(Random_number);

// Console.WriteLine($"Число равно: {Random_number}");
// Console.WriteLine($"Самое большое число равно: {BigNumber}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.




// // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int Find_Number_Max(int number) // объявляем метод и количество переменных
// {
//      int edin = number % 10; // выделяем остаток
//      int sotni = number / 100; // удаляем остаток, крайние 2 цифры
//      int length_number = sotni * 10 + edin; // получаем число из 2 цифр

//      return length_number; // возвращаем результат метода
// }

// int Random_number = new Random().Next(100, 1000); // получаем трехзначное псевдослучайное число 
// int two_number = Find_Number_Max(Random_number); // запускаем метод, результат записываем в переменную

// // Console.WriteLine(Random_number); // показываем рандомное число для проверки
// Console.WriteLine($"После удаления второй цифры, осталось число: {two_number}"); // записываем результат



// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// void Multiplicity(int number_1, int number_2) // создаем метод, объявляем переменные
// {
//     if(number_1 < number_2) Console.WriteLine("Первое число должно быть больше второго"); // проверяем корректность введенных чисел
//     else // если все верно
//     {
//         if(number_1 % number_2 == 0) // если нет остатка то
//         {
//             Console.WriteLine($"{number_2} является кратным {number_1}"); // пишем в консоли в случае кратности чисел
//         }
//         else
//         {
//             int res = number_1 % number_2; // записываем остаток от кратности в переменную
//             Console.WriteLine($"{number_2} не является кратным {number_1}, остаток от деления {res}"); // пишем в консоли в случае если не кратно
//         }
//     }
// }
// Console.Write("Введите первое число: "); // запрашиваем первое число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число один
// Console.Write("Введите второе число: "); // запрашиваем второе число
// int num_2 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число два

// Multiplicity(num_1, num_2); // запускаем метод
