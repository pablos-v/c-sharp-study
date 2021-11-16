// 41. Выяснить являются ли три числа сторонами треугольника 
// В треугольнике сумма длин двух любых сторон больше длины третьей стороны

// bool TrianglRule(int a, int b, int c)
// {
//     return a + b > c && a + c > b && b + c > a;
// }

// Console.Write(TrianglRule(5, 8, 6));

// 42. Определить сколько чисел больше 0 введено с клавиатуры

// int F42(int N)
// {
//     int count = 0;
//     for (int i = 0; i < N; i++)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());
//         if (number > 0) count++;
//     }
//     return count;
// }

// Console.Write(F42(5));

// 43. Написать программу преобразования десятичного числа в двоичное

//  сам через массив
// int ArrLength(int arg) // length of new number
// {
//     int res = 0;
//     while (arg > 0)
//     {
//         arg /= 2;
//         res++;
//     }
//     return res;
// }

// int[] Converter(int arg)
// {
//     int[] res = new int[ArrLength(arg)];
//     for (int i = res.Length - 1; i >= 0; i--)
//     {
//         res[i] = arg % 2;
//         arg /= 2;
//     }
//     return res;
// }

// Console.Write(string.Join("", Converter(20)));

// через строку

// string Converter(int arg)
// {
//     string res = string.Empty;
//     while (arg > 0)
//     {
//         res = (arg % 2) + res;
//         arg /= 2;
//     }
//     return res;
// }

// Console.Write(Converter(20));

// рекурсивно подсмотрел
// string FuncTo2(int a)
// {
//     if (a == 1) return "1";
//     else return FuncTo2(a / 2) + (a % 2);
// }
// Console.Write(FuncTo2(4));

//  конвертер вшитый в C#
// int x = 4;
// Console.Write(Convert.ToString(x, 2)); // 2 - основание системы счисления

// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы



// 45. Показать числа Фибоначчи



// 46. Написать программу масштабирования фигуры



// 47. Написать программу копирования массива


