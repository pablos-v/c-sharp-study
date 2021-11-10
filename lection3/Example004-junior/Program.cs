// 15. Дано число. Проверить кратно ли оно 7 и 23

// void Krat(int x, int a, int b)
// {
//     if (x % a == 0 && x % b == 0) Console.Write($"Число {x} кратно числам {a} и {b}.");
//     else Console.Write($"Число {x} не кратно ни одному делителю.");
// }
// Krat(161, 7, 23);

// bool Kratno(int a, int b, int c)
// {
//     return (a % b % c == 0);
// }
// if (Kratno(322, 7, 23)) Console.Write("Кратно");
// else Console.Write("Не кратно");

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём

// bool Day(int n)
// {
//     return (n == 6 || n == 7);
// }
// if (Day(5)) Console.WriteLine("Выходной");
// else Console.WriteLine("Будний день");

// 17. По двум введённым числам проверять является ли одно квадратом другого

// Вариант "Скучный"
// bool IfQuad(int a, double b)
// {
//     return (Math.Sqrt(a) == b);
// }
//     if (IfQuad(100, 10)) Console.WriteLine ("Является квадратом");
//     else Console.WriteLine ("Не является квадратом");

// Вариант "интересный"

// string OutLine(int[] num)
// {
//     if (Math.Sqrt(num[0]) == num[1]) return ($"Число {num[0]} является квадратом числа {num[1]}");
//     else return ($"Число {num[0]} НЕ является квадратом числа {num[1]}");
// }

// int[] Enter()
// {
//     int[] num=new int[2];
//     Console.WriteLine("Введите первое число ");
//     num[0] = int.Parse(Console.ReadLine());
//     Console.WriteLine("Введите второе число ");
//     num[1] = int.Parse(Console.ReadLine());
//     return (num);
// }

// Console.WriteLine(OutLine(Enter()));

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool Boo(bool X, bool Y)
// {
//     return ((!(X || Y)) == (!X && !Y));
// }

// if (Boo(true, true) && Boo(true, false) && Boo(false, true) && Boo(false, false)) Console.WriteLine("Утверждение истинно.");
// else Console.WriteLine("Утверждение ложно.");

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// void Decart(double x, double y)
// {
// if (x == 0 || y == 0) Console.Write("Координаты должны быть отличны от нуля.");
// if (x > 0 && y > 0) Console.Write("Точка находится в 1 четверти.");
// if (x < 0 && y > 0) Console.Write("Точка находится во 2 четверти.");
// if (x < 0 && y < 0) Console.Write("Точка находится в 3 четверти.");
// if (x > 0 && y < 0) Console.Write("Точка находится в 4 четверти.");
// }
// Decart(3, -2.6);

// string Decart(double x, double y)
// {
// if (x == 0 || y == 0) return "Координаты должны быть отличны от нуля.";
// else if (x > 0 && y > 0) return "Точка находится в 1 четверти.";
// else if (x < 0 && y > 0) return "Точка находится во 2 четверти.";
// else if (x < 0 && y < 0) return "Точка находится в 3 четверти.";
// else return "Точка находится в 4 четверти.";
// }
// Console.Write(Decart(3, -2.6));

// 20. Ввести номер четверти, показать диапазоны для возможных координат

// void Decart()
// {
//     Console.WriteLine("Введите номер четверти:");
//     int n = int.Parse(Console.ReadLine());

//     if (n > 4 || n < 1) Console.WriteLine("Хватить баловаться, мы тут серьёзные лица делаем, так надо.");
//     if (n == 1) Console.WriteLine("Допустимый предел значений: все положительные значения по осям X и Y.");
//     if (n == 2) Console.WriteLine("Допустимый предел значений: все отрицательные значения по оси X и все положительные по оси Y.");
//     if (n == 3) Console.WriteLine("Допустимый предел значений: все отрицательные значения по осям X и Y.");
//     if (n == 4) Console.WriteLine("Допустимый предел значений: все положительные значения по оси X и все отрицательные по оси Y.");
// }
// Decart();

// string Decart()
// {
//     Console.WriteLine("Введите номер четверти:");
//     int n = int.Parse(Console.ReadLine());
//     if (n > 4 || n < 1) return ("Хватить баловаться, мы тут серьёзные лица делаем, так надо.");
//     else if (n == 1) return ("Допустимый предел значений: все положительные значения по осям X и Y.");
//     else if (n == 2) return ("Допустимый предел значений: все отрицательные значения по оси X и все положительные по оси Y.");
//     else if (n == 3) return ("Допустимый предел значений: все отрицательные значения по осям X и Y.");
//     else return ("Допустимый предел значений: все положительные значения по оси X и все отрицательные по оси Y.");
// }
// Console.WriteLine(Decart());

// 21. Программа проверяет пятизначное число на палиндром.

// bool Palin(int n)
// {
//     return (n / 10000 == n % 10 && (n / 1000) % 10 == (n % 100) / 10);
// }
// if (Palin(54345)) Console.WriteLine("Это палиндром");
// else Console.WriteLine("Не палиндром");

// 22. Найти расстояние между точками в пространстве 2D/3D

// 2D методами с вводом

// double[] Enter()
// {
//     double[] x1y1x2y2= new double[4];
//     Console.WriteLine("X-координата первой точки: ");
//     x1y1x2y2[0] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Y-координата первой точки: ");
//     x1y1x2y2[1] = double.Parse(Console.ReadLine());
//     Console.WriteLine("X-координата второй точки: ");
//     x1y1x2y2[2] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Y-координата второй точки: ");
//     x1y1x2y2[3] = double.Parse(Console.ReadLine());
//     return x1y1x2y2;
// }

// double Pifagor()
// {
// double[] x1y1x2y2= Enter();
// double a = Math.Abs(x1y1x2y2[0] - x1y1x2y2[2]);
// double b = Math.Abs(x1y1x2y2[1] - x1y1x2y2[3]);
// double result = Math.Sqrt(a * a + b * b);
// return result;
// }

// Console.WriteLine("Расстояние между точками составляет " + Pifagor());

// 3D




