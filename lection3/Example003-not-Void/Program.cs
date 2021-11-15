// 0 вывести квадрат числа

// int Squad(int X)
// {
//     return X*X;
// }

// Console.Write(Squad(10));

// 1. По двум введённым числам проверять является ли первое квадратом второго

// Console.WriteLine("Введите первое число ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = int.Parse(Console.ReadLine());

// bool Sqrt(int a, int b)
// {
//     return (a==b*b);
// }

// if (Sqrt(a, b)) Console.Write("Квадрат");
// else Console.Write("Не квадрат");

//  2. Даны два числа. Показать большее и меньшее число

// string Max(int a, int b)
// {
//     if (a > b) return ($"Max = {a}, min = {b}");
//     else return ($"Max = {b}, min = {a}");
// }
// Console.WriteLine(Max(5, 7));

// вариант 2

// bool F2(int a, int b)
// {
//     return a > b;
// }

// int a = 15;
// int b = 10;
// if (F2(a, b)) Console.Write($"Число {a} больше числа {b}.");
// else Console.Write($"Число {b} больше числа {a}.");

// вариант 3
// (int, int) F2_2(int a, int b)
// {
//     if (a > b) return (a, b);
//     else return (b, a);
// }

// int a = 15;
// int b = 10;
// Console.Write($"Максимальное и минимальное число соответственно: {F2_2(a, b)}.");

//  3. По введенному номеру дня недели вывести его название

// string WeekDay(int current)
// {
//     string[] week = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//     return week[current-1];
// }
// Console.WriteLine("Сегодня " + WeekDay(3));

//  4. Найти максимальное из трех чисел

// int Max(int a, int b, int c)
// {
//     int max = a;
//     if (b > max) max = b;
//     if (c > max) max = c;
//     return max;
// }
// Console.WriteLine($"Максимальное число {Max(15, 9, 14)}");

//  5. Написать программу вычисления значения функции y=f(a)

// double Sin(double degrees)
// {
//     double angle = Math.PI * degrees / 180.0;
//     return Math.Sin(angle);
// }
// double a = 1;
// Console.WriteLine($"синус {a} = {Sin(a)}");

//  6. Выяснить является ли число чётным

// bool Even(int a)
// {
//     return (a % 2 == 0);
// }
// if (Even(0)) Console.WriteLine("Чёт");
// else Console.Write("Нечет");

//  7. Показать числа от -N до N

// int[] CreateArray(int arg)
// {
//     int[] arrayA = new int[arg * 2 + 1];
//     for (int i = -arg; i <= arg; i++)
//     {
//         arrayA[i + arg] = i;
//     }
//     return arrayA;
// }

// int[] arr = CreateArray(10);
// Console.WriteLine(String.Join(',', arr));

//  8. Показать четные числа от 1 до N

// int[] CreateArray(int arg)
// {
//     int[] arrayA = new int[arg];
//     for (int i = 1; i <= arg; i++)
//     {
//         arrayA[i-1] = i;
//     }
//     return arrayA;
// }

// int[] arr = CreateArray(7);
// Console.WriteLine(String.Join(',', arr));

//  9. Показать последнюю цифру трёхзначного числа

// int lastNum (int num)
// {
//     return num % 10;
// }
// Console.WriteLine(lastNum(125));

// 10. Показать вторую цифру трёхзначного числа

// int secondNum (int num)
// {
//     return (num / 10) % 10;
// }
// Console.WriteLine(secondNum(125));

// 12. Удалить вторую цифру трёхзначного числа

// string Num(int a)
// {
//     return $"Получаем двузначное число {a / 100}{a % 10}";
// }
// Console.WriteLine(Num(658));

// лучше так:

// int number(int a)
// {
//     return a / 100 * 10 + a % 10;
// }
// Console.WriteLine($"Получаем двузначное число {number(135)}");

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

// вариант 2
// bool Krat(int a, int b)
// {
//     return a % b == 0;
// }
// int a = 20;
// int b = 11;

// if (Krat(a, b)) Console.Write("Делимое кратно делителю!");
// else Console.Write($"Нацело не делится, остаток от деления {a % b}");
// ------------------------

// 14. Найти третью цифру числа или сообщить, что её нет

// первое решение с наскока
// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// if (num.Length > 2) Console.Write(num[2]);
// else Console.Write("В заданном числе нет третьей цифры!");

// математическое решение
// int F27(int N)   // сколько цифр в числе
// {
//     int x = 1;
//     while (N > 10)
//     {
//         N /= 10;
//         x++;
//     }
//     return x;
// }

// int Del(int X)      // готовит делитель, отсекающий число до трёхзначного
// {
//     int del = 10;
//     for (int i = 1; i < X - 3; i++)
//     {
//         del *= 10;
//     }
//     return del;
// }

// void Counter(int number)
// {
// if (number < 100) Console.Write("В заданном числе нет третьей цифры!");
// else if (number < 1000) Console.Write(number % 10);
// else Console.Write((number / Del(F27(number))) % 10);
// }

// Counter(987654);