// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// int CountNumbers() // создаем метод
// {
//     Console.WriteLine("Какое количество чисел будете вводить: ");
//     int count = Convert.ToInt32(Console.ReadLine()); // создаем переменную спрашиваем число
//     int sum = 0; // создаем переменную
//     for(int i = 0; i < count; i++) // объявляем цикл
//     {
//          Console.WriteLine($"Введите {i + 1} число: ");
//          int number = Convert.ToInt32(Console.ReadLine()); // записываем, переписываем переменную
//          if(number > 0) sum++; // если больше счетчик + 1
//     }
//     return sum; // возвращаем сумму
// }


// Console.WriteLine($"Количество чисел больше '0': {CountNumbers()}"); // сумму выводим на экран

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// void FindIntersectionPoint() // объявляем метод
// {
//     Console.Write("Введите b1: "); // введите число b1
//     double b1 = Convert.ToDouble(Console.ReadLine()); // создаем переменную спрашиваем число
//     Console.Write("Введите k1: "); // введите число k1
//     double k1 = Convert.ToDouble(Console.ReadLine()); // создаем переменную спрашиваем число
//     Console.Write("Введите b2: "); // введите число b2
//     double b2 = Convert.ToDouble(Console.ReadLine()); // создаем переменную спрашиваем число
//     Console.Write("Введите k2: "); // введите число k2
//     double k2 = Convert.ToDouble(Console.ReadLine()); // создаем переменную спрашиваем число

//     double x = (b2 - b1) / (k1 - k2); // решаем
//     double y = k1 * x + b1; // еще раз решаем


//     if((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
//     else
//     {
//         if (k1==k2) Console.WriteLine("Прямые параллельны");
//         else Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}"); // выводим ответ
//     }
// }

// FindIntersectionPoint(); // применяем метод
