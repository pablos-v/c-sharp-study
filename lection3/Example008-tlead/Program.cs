// 41. Выяснить являются ли три числа сторонами треугольника 
// В треугольнике сумма длин двух любых сторон больше длины третьей стороны

// uint[] Enter() //ввести все 3 разом с провернкой
// {
//     while (true)
//     {
//         Console.Write("Введите длины трёх сторон треугольника через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ');
//         if (enter.Length == 3)
//         {
//             return TParse(enter);
//             break;
//         }
//         else Console.Write("Ввести можно только 3 числа через запятую, попробуйте снова.\n");

//     }
// }

// uint[] TParse(string[] arr)
// {
//     uint[] abc = new uint[3];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (uint.TryParse(arr[i], out uint num)) abc[i] = num;
//         else
//         {
//             Console.Write("Длина стороны может быть только целым положительным числом. Перезапустите программу.");
//             Environment.Exit(0);
//         }
//     }
//     return abc;
// }

// bool TrianglRule(uint[] abc)
// {
//     return abc[0] + abc[1] > abc[2] && abc[0] + abc[2] > abc[1] && abc[1] + abc[2] > abc[0];
// }

// if (TrianglRule(Enter())) Console.Write("Да, из этого можно слепить треугольник.");
// else Console.Write("Такого треугольника быть не может.");

// 42. Определить сколько чисел больше 0 введено с клавиатуры

// int Enter() // с проверкой
// {
//     int count = 0;
//         Console.Write("Введите ряд чисел через запятую или через пробел: ");
//         string[] enter = Console.ReadLine().Split(',', ' ');
//         for (int i = 0; i < enter.Length; i++)
//         {
//             if (double.TryParse(enter[i], out double num))
//             {
//                 if (num > 0) count++;
//             }
//             else
//             {
//                 Console.Write("Хватит хулиганить, давайте заново.");
//                 Environment.Exit(0);
//             }
//         }
//             return count;
// }

// int Enter() //без проверки
// {
//     int count = 0;
//         Console.Write("Введите ряд чисел через запятую или через пробел: ");
//         string[] enter = Console.ReadLine().Split(',', ' ');
//         for (int i = 0; i < enter.Length; i++)
//         {
//             if (double.TryParse(enter[i], out double num) && num > 0) count++;
//         }
//         return count;
// }

// Console.Write($"Вы указали {Enter()} чисел больших 0.");

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

// через строку со вводом

// int Enter()
// {
//     while (true)
//     {
//         Console.Write("Введите десятичное число: ");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.Write("Ввести нужно десятичное число, попробуйте снова.\n");
//     }
// }

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

// Console.Write(Converter(Enter()));

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

// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы

// y=kx+b это уравнение прямой с угловым коэффициентом k
// x, y - это координаты точек, лежащих на прямой
// зная k и b и подставляя произвольные значения х, получим точку у и построим прямую

// (double, double) YaOfigel(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     return (x, y);
// }

// double b1 = 1;
// double k1 = -3;
// double b2 = -1;
// double k2 = 2;

// if (k1 == k2 && b1 != b2) Console.Write("Параллельны");
// else if (k1 == k2 && b1 == b2) Console.Write("Совпадают");
// else Console.Write("Точка пересечения: " + YaOfigel(b1, k1, b2, k2));

// 45. Показать числа Фибоначчи

// void методом 

// int Enter()
// {
//     while (true)
//     {
//         Console.Write("До какого числа будем Фибоначчить?: ");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.Write("Ввести нужно десятичное положительное число, попробуйте снова.\n");
//     }
// }

// void Fibo(int arg)
// {
//     int a = 0;
//     int b = 1;
//     int c = 0;
//     Console.Write($"{a} {b}");
//     for (int i = 3; i <= arg; i++)
//     {
//         c = a + b;
//         Console.Write(" " + c);
//         a = b;
//         b = c;
//     }
// }

// Fibo(Enter());

// ЧЕРЕЗ массив!!!!

// int Enter()
// {
//     while (true)
//     {
//         Console.Write("До какого числа будем Фибоначчить?: ");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.Write("Ввести нужно десятичное положительное число, попробуйте снова.\n");
//     }
// }

// int[] Fibo(int arg)
// {
//     int[] arr = new int[arg];
//     int a = 0;
//     int b = 1;
//     int c = 0;
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i <= arg-1; i++)
//     {
//         c = a + b;
//         arr[i] = c;
//         a = b;
//         b = c;
//     }
//     return arr;
// }

// Console.Write(string.Join(" ", Fibo(Enter())));

// 46. Написать программу масштабирования фигуры
// + ПРОВЕРКА ВВОДА
// (1;2),(3;5),
// ------------1 вариант-------------------------
// int Len() // задать форму
// {
//     Console.WriteLine("Сколько опорных точек у фигуры: ");
//     return int.Parse(Console.ReadLine());
// }

// double[,] Figure(int length) // задать фигуру  массив кортежей!!
// {
//     double[,] coordinates = new double[length, 2];
//     string axis = string.Empty;
//     for (int i = 0; i < length; i++)
//     {
//         axis = "x";
//         for (int j = 0; j < 2; j++)
//         {
//             Console.WriteLine($"Введите координату {axis} {i + 1} точки: ");
//             coordinates[i, j] = double.Parse(Console.ReadLine());
//             axis = "y";
//         }
//     }
//     return coordinates;
// }

// double Mult() // задать кратность
// {
//     Console.WriteLine("Задайте кратность масштабирования: ");
//     double resize = double.Parse(Console.ReadLine());
//     return resize;
// }

// double[,] Formula(double[,] arr, double k, int len) // формула
// {
//     double[,] answer = new double[len, 2];
//     for (int i = 0; i < len; i++)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             answer[i, j] = arr[i, j] * k;
//         }
//     }
//     return answer;
// }

// void PrintIt(int len, double[,] arr)
// {
// string axis = string.Empty;
// for (int i = 0; i < len; i++)
// {
//     Console.Write($"\n{i + 1} точка: ");
//     axis = "x=";
//     for (int j = 0; j < 2; j++)
//     {
//         Console.Write(axis + string.Join("", arr[i, j])+ " ");
//         axis = "y=";
//     }
// }
// }

// int len = Len();
// double[,] arr = Figure(len);
// double[,] arr2 = Formula(arr, Mult(), len);

// Console.WriteLine("Координаты опорных точек заданной фигуры: "); PrintIt(len, arr);
// Console.WriteLine("\n");
// Console.WriteLine("Координаты опорных точек масштабированной фигуры: "); PrintIt(len, arr2);

// ------------ 2 вариант -------------------------

// int Len() // задать форму
// {
//     while (true)
//     {
//         Console.WriteLine("Сколько опорных точек у фигуры: ");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// double[] Enter(int length) // задать фигуру
// {
//     while (true)
//     {
//         double[] coordinates = new double[length * 2];
//         Console.WriteLine("Введите координаты точек в формате (x1,y1) (x2,y2): ");
//         string[] enter = Console.ReadLine().Split(',', ' ', ')', '(');
//         while (enter.Length == length * 2)
//         {
//             int count = 0;
//             for (int i = 0; i < length * 2; i++)
//             {
//                 if (double.TryParse(enter[i], out double num)) coordinates[i] = num;
//                 else count = 1;
//             }
//             if (count == 0) return coordinates;
//             else break;
//         }
//         Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// double Mult() // задать кратность
// {
//     while (true)
//     {
//         Console.WriteLine("Задайте кратность масштабирования: ");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// (double x, double y)[] Cortage(double[] arr, double k) //  метод разбора на кортежи + масштабирование
// {
//     (double x, double y)[] coor = new (double x, double y)[arr.Length];
//     int d = 0;
//     for (int i = 0; i < arr.Length; i += 2)
//     {
//         coor[d++] = (arr[i]*k, arr[i + 1]*k);
//     }
//     return coor;
// }

// void PrintIt((double x, double y)[] arr)
// {
//     Console.WriteLine("Координаты опорных точек масштабированной фигуры: ");
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         Console.WriteLine(string.Join(' ', arr[i]));
//     }
// }

// PrintIt(Cortage(Enter(Len()), Mult()));

// 47. Написать программу копирования массива

// 1 вариант без ввода
// int[] RandArray(int a)
// {
//     int[] arrA = new int[a];
//     for (int i = 0; i < arrA.Length; i++)
//     {
//         arrA[i] = new Random().Next(10, 20);
//     }
//     return arrA;
// }

// int[] Copy(int[] arr)
// {
//     int[] arrB = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arrB[i] = arr[i];
//     }
//     return arrB;
// }

// int[] arrA=RandArray(7);

// Console.Write(string.Join(" ", arrA));
// Console.WriteLine();
// Console.Write(string.Join(" ", Copy(arrA)));

// 2 вариант со вводом и проверкой----------------------------

// int[] Enter()
// {
//     while (true)
//     {
//         Console.WriteLine("Введите массив чисел, разделяя их пробелом или запятыми: ");
//         string[] enter = Console.ReadLine().Split(',', ' ');
//         int[] arr = new int[enter.Length];
//         bool fault = false;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (int.TryParse(enter[i], out int num)) arr[i] = num;
//             else fault = true;
//         }
//         if (fault) Console.WriteLine("Что-то введено не так, давайте попробуем снова.");
//         else return arr;
//     }
// }

// int[] Copy(int[] arr)
// {
//     int[] arrB = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arrB[i] = arr[i];
//     }
//     return arrB;
// }

// Console.Write(string.Join(" ", Copy(Enter())));