// Домашнее задание

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
//     for(int i = 1; i < num_b; i++) // объявляем цикл for
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

int [] InputMassive()
{
    int length_massive = 1;
    int [] array = new int [length_massive];
    
    for(int i = 0; i < length_massive; i++)
    {
        Console.Write("Введите число: "); // запрашиваем число
        int current = Convert.ToInt32(Console.ReadLine());
        array[i] = current; // записываем число в переменную
        Console.WriteLine($"Добавлено число {array[i]}"); // выводим результат
    }
    Console.WriteLine($"Добавлено число вот {array[]}"); // выводим результат    
    return array;
}


Console.WriteLine($"Сумма цифр в числе равна: {InputMassive()}"); // выводим результат

















// int FindSum(int num)
// {
//     int sum = 0;

//     for(int i = 1; i > sum; i++)
//     {
//         i += 1;
//     }
//     return sum;
// }
// Console.Write("Введите число: "); // запрашиваем число
// int a = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
// FindSum(a);
// Console.WriteLine($"{a},{a})");


// int CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// int [] a = CreateRandomArray(5,1,19);
// Console.WriteLine($"{a},{a})");