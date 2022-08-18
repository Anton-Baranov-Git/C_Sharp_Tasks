// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 > number_2)
{
    Console.WriteLine($"Первое число {number_1} больше, чем второе число {number_2}");
}
else
{
    Console.WriteLine($"Первое число {number_1} меньше, чем второе число {number_2}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(number_1 > number_2)
{
    max = number_1;
    if(max > number_3)
    {
        Console.WriteLine($"Первое число - {number_1} является максимальным");
    }
    else
    {
        Console.WriteLine($"Третье число - {number_3} является максимальным");
    }
}
else
{
    max = number_2;
    if(max > number_3)
    {
        Console.WriteLine($"Второе число - {number_2} является максимальным");
    }
    else
    {
        Console.WriteLine($"Третье число - {number_3} является максимальным");
    }
}
*/

// Та же задача только дополнительно проверка на равенство: 
/*
Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number_1 == number_2 & number_3 == number_1)
{
    Console.WriteLine($"Вы ввели три числа равны {number_1}, максимальным является {number_1}");
}
else
{
    if(number_1 == number_2 & number_1 > number_3)
    {
        Console.WriteLine($"Первое число - {number_1} и второе число {number_2} равны друг другу и являются максимальными");
    }
    if(number_1 == number_3 & number_1 > number_2)
    {
        Console.WriteLine($"Первое число - {number_1} и третье число {number_3} равны друг другу и являются максимальными");
    }
    if(number_2 == number_3 & number_2 > number_1)
    {
        Console.WriteLine($"Второе число - {number_2} и третье число {number_3} равны друг другу и являются максимальными");
    }
    else
    {
        if(number_1 > number_2 & number_1 > number_3)
        {
            Console.WriteLine($"Первое число - {number_1} является максимальным");
        }
        if(number_2 > number_1 & number_2 > number_3)
        {
            Console.WriteLine($"Второе число - {number_2} является максимальным");
        }
        if(number_3 > number_1 & number_3 > number_2)
        {
            Console.WriteLine($"Третье число - {number_3} является максимальным");
        }
    }
}
*/


/*
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} не является четным");
}
*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

if(number <= 1)
{
    Console.WriteLine("В условие задачи четные числа должны быть больше 1, введите любое число больше 1");
}
else
{
    Console.Write($"Все четные числа от 1 до {number}: ");
    while(i <= number)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}





// Задания с семинара
// найти квадратный корень
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Квадрат " + number + " равен " + number * number);
Console.WriteLine($"Квадрат {number} равен {number * number}");
*/

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Введите число один: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число два: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if(number_2 * number_2 == number_1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
*/

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number * (-1);
while(i <= number)
{
    Console.Write(i + " ");
    i++;
}
*/

