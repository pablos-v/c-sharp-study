// вывести квадрат числа

// Console.Write("Введите число: ");
// string x = Console.ReadLine();
// int X = int.Parse(x);

// void Squad(int X)
// {
//     Console.Write(X*X);
// }

// Squad(X);
// ---------------------------------------

//По введенному номеру дня недели вывести его название

// void Number()
// {
// Console.Write("Введите номер дня недели: ");
// string x = Console.ReadLine();
// int num = int.Parse(x);

// string[] erty= {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

// Console.Write(erty[num-1]);
// }
// Number();
// -------------------------------

// Написать программу вычисления значения функции y=Sin(a)

// double Sin(double degrees)
// {
//     double angle = Math.PI * degrees / 180.0;
//     return Math.Sin(angle);
// }
// double a = 1;
// Console.WriteLine($"синус {a} = {Sin(a)}");
// ----------------------------------\

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// void maxNumber (int number)
// {
//     int numberOne = number / 10;
//     int numberTwo = number % 10;

//     if (numberOne>numberTwo)
//     {
//         Console.WriteLine($"В числе {number} наибольшая цифра {numberOne}");
//     }
//     else
//     {
//         Console.WriteLine($"В числе {number} наибольшая цифра {numberTwo}");
//     }
// }
// maxNumber(new Random().Next(10, 100));
//  2 вариант через массив char
// char maxNumber (char[] number)
// {
//     if (number[0]>number[1]) return number[0];
//     else return number[1];
// }
// int i = new Random().Next(10, 100);
// char[] arr = i.ToString().ToCharArray();
// Console.WriteLine($"В числе {i} наибольшая цифра {maxNumber(arr)}");
// ------------------------

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// int[] Input()
// {
//     int[] numbers = new int[2];
//     Console.Write("Введите делимое: ");
//     string a = Console.ReadLine();
//     numbers[0] = int.Parse(a);
//     Console.Write("Введите делитель: ");
//     string b = Console.ReadLine();
//     numbers[1] = int.Parse(b);
//     return numbers;
// }
// void Check(int[] numbers)
// {
//     if (numbers[0] % numbers[1] == 0) Console.Write("Делимое кратно делителю!");
//     else Console.Write($"Нацело не делится, остаток от деления {numbers[0] % numbers[1]}");
// }

// Check(Input());
// ------------------------

// 14. Найти третью цифру числа или сообщить, что её нет

