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

// !!!!!!!!!!! вариант 4 с сокращённой записью методов !!!!!!!!!
// N

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

// int[] CreateArray(int N)
// {
//     int[] arrayA = new int[N * 2 + 1];
//     for (int i = -N; i <= N; i++)
//     {
//         arrayA[i + N] = i;
//     }
//     return arrayA;
// }

// int[] arr = CreateArray(5);
// Console.WriteLine(String.Join(", ", arr));

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

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
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
// 3 вариант лучший
// int F11(int i)
// {
//     if (i / 10 > i % 10) return i / 10;
//     else return i % 10;
// }
// int i = new Random().Next(10, 100);
// Console.WriteLine(i);
// Console.Write(F11(i));

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

//математическое решение
// int F27(int N)   // сколько цифр в числе вариант 1
// {
//     int x = 1;
//     while (N > 10)
//     {
//         N /= 10;
//         x++;
//     }
//     return x;
// }

// int F27(int N)   // сколько цифр в числе вариант 2
// {
//     return N.ToString().Length;
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

// // код Володи
// int FindThirdNum(int arg) 
// { 
//     if(arg / 100 == 0) return -1; 
//     else  
//     { 
//         while(arg / 100 > 9) arg = arg / 10; 
//         return arg % 10; 
//     } 
// }

// Console.Write(FindThirdNum(123456));


// 15. Дано число. Проверить кратно ли оно 7 и 23

// void Krat(int x, int a, int b)
// {
//     if (x % a == 0 && x % b == 0) Console.Write($"Число {x} кратно числам {a} и {b}.");
//     else Console.Write($"Число {x} не кратно ни одному делителю.");
// }
// Krat(161, 7, 23);

// вариант 2
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
// if (IfQuad(100, 10)) Console.WriteLine ("Является квадратом");
// else Console.WriteLine ("Не является квадратом");

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
//     double[] x1y1x2y2 = Enter();
//     // double a = Math.Abs(x1y1x2y2[0] - x1y1x2y2[2]);
//     // double b = Math.Abs(x1y1x2y2[1] - x1y1x2y2[3]);
//     double result = Math.Sqrt(Math.Pow(Math.Abs(x1y1x2y2[0] - x1y1x2y2[2]),2) 
//     + Math.Pow(Math.Abs(x1y1x2y2[1] - x1y1x2y2[3]),2));
//     return result;
// }

// Console.WriteLine("Расстояние между точками составляет " + Pifagor());

// 3D методами с вводом

// double[] Enter()
// {
//     double[] coord = new double[6];
//     Console.WriteLine("X-координата первой точки: ");
//     coord[0] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Y-координата первой точки: ");
//     coord[1] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Z-координата первой точки: ");
//     coord[2] = double.Parse(Console.ReadLine());
//     Console.WriteLine("X-координата второй точки: ");
//     coord[3] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Y-координата второй точки: ");
//     coord[4] = double.Parse(Console.ReadLine());
//     Console.WriteLine("Z-координата второй точки: ");
//     coord[5] = double.Parse(Console.ReadLine());
//     return coord;
// }

// double Pifagor()
// {
//     double[] coord = Enter();
//     double result = Math.Sqrt(Math.Pow(Math.Abs(coord[0] - coord[3]),2) 
//     + Math.Pow(Math.Abs(coord[1] - coord[4]),2) 
//     + Math.Pow(Math.Abs(coord[2] - coord[5]),2));
//     return result;
// }

// Console.WriteLine("Расстояние между точками составляет " + Pifagor());

// 23. Показать таблицу квадратов чисел от 1 до N 

// void F23(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write($" {i*i}");
//     }
// }
// F23(10);

// вариант 2
// int[] F23(int n)
// {
//     int[] arr = new int[n];
//     for (int i = 1; i <= arr.Length; i++)
//     {
//         arr[i-1] = i*i;
//     }
//     return arr;
// }
// Console.WriteLine(String.Join(", ", F23(5)));

// 24. Найти кубы чисел от 1 до N

// void F23(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write($" {i*i*i}");
//     }
// }
// F23(10);

// int[] F23(int n)
// {
//     int[] arr = new int[n];
//     for (int i = 1; i <= arr.Length; i++)
//     {
//         arr[i-1] = i*i*i;
//     }
//     return arr;
// }
// Console.WriteLine(string.Join(", ", F23(5)));

// 25. Найти сумму чисел от 1 до А

// void F23(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }
//     Console.Write(sum);
// }
// F23(10);

// быстрый вариант Сергея
// int F23(int A)
// {
//     return (A*(A+1))/2; 
// }
// DateTime dt = DateTime.Now;
// Console.WriteLine(F23(10000000));
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// 26. Возведите число А в натуральную степень B используя цикл

// int F26(int A, int B)
// {
//     int res = A;
//     for (int i = 2; i <= B; i++)
//     {
//         res = res * A;
//     }
//     return res;
// }
// Console.Write(F26(2, 7));

// 27. Определить количество цифр в числе

// int F27(int N)
// {
//     return (N.ToString().ToCharArray()).Length;
// }
// Console.Write(F27(1234567));

// математический метод
// int F27(int N)
// {
//     int x = 1;
//     while (N > 10)
//     {
//         N /= 10;
//         x++;
//     }
//     return x;
// }
// Console.Write(F27(1234567));

// 28. Подсчитать сумму цифр в числе

// int Sum(int m)
// {
//     int res = 0;
//     while (m > 0)
//     {
//         res += (m % 10);
//         m /= 10;
//     }
//     return res;
// }
// Console.Write(Sum(12345));

// 29. Написать программу вычисления произведения чисел от 1 до N

// циклом
// int F23(int N)
// {
//     int arr = 1;
//     if (N < 1) return 0;
//     else
//     {
//         for (int i = 1; i <= N; i++)
//         {
//             arr *= i;
//         }
//     }
//     return arr;
// }
// Console.WriteLine(F23(3));

// рекурсивно
// int F23(int N)
// {
//     if (N < 1) return 0;
//     else if (N == 1) return 1;
//     else return N * F23(N - 1);
// }
// Console.WriteLine(F23(5));

// 30. Показать кубы чисел, заканчивающихся на четную цифру (диапазон возьму от 10 до 20)

// если про чётность кубов
// void F23(int N, int F)
// {
//     for (int i = N; i <= F; i++)
//     {
//         if ((i * i * i) % 2 == 0) Console.Write($" {i * i * i}");
//     }
// }
// F23(10, 20);

// если про чётность заданных чисел
// void F23(int N, int F)
// {
//     for (int i = N; i <= F; i++)
//     {
//         if (i % 2 == 0) 
//         {
//             Console.Write($"{i}-");
//             Console.Write($"{i * i * i}  ");            
//         }
//     }
// }
// F23(10, 20);

// через массивы
// int[] F23(int N, int F)
// {
//     int m = 0;
//     int[] num = new int[((F - N) / 2) + 1];
//     for (int i = N; i <= F; i++)
//     {
//         if (i % 2 == 0)
//         {
//             num[m++] = i * i * i;
//         }
//     }
//     return num;
// }
// Console.WriteLine(string.Join(", ", F23(10, 20)));


// 31. Задать массив из 8 элементов и вывести их на экран 

// int[] Arr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         Console.Write($"Введите {i} элемент массива: ");
//         arr[i]= int.Parse(Console.ReadLine());
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
// }

// PrintArr(Arr(8));

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i]= new Random().Next(0,2);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
// }

// PrintArr(RandArr(15));

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива


// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i]= new Random().Next(-9,10);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
// }

// (int, int) Sum(int[] arr)
// {
//     int sump=0;
//     int summ=0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]>0) sump+=arr[i];
//         else summ+=arr[i];
//     }
//     return (sump, summ);
// }

// int[] array=RandArr(12);
// PrintArr(array);
// Console.WriteLine($"Сумма положительных и отрицательных чисел массива соответственно: {Sum(array)}");

// 34. Написать программу замену элементов массива на противоположные (по знаку?)

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i]= new Random().Next(-9,10);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]+" ");
//     }
//     Console.WriteLine(" ");
// }

// int[] RevArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]=arr[i]*-1;
//     }
//     return arr;
// }

// int[] array=RandArr(12);
// PrintArr(array);
// PrintArr(RevArr(array));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++) arr[i] = new Random().Next(-9, 10);
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
// }

// bool Search(int[] arr, int N)
// {
//     bool x = false;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == N)
//         {
//             x = true;
//             break;
//         }
//     }
//     return x;
// }

// int[] array = RandArr(new Random().Next(10, 15));
// Console.Write("Какое число ищем: ");
// int a = int.Parse(Console.ReadLine());
// PrintArr(array);
// if (Search(array, a)) Console.Write("Есть такое.");
// else Console.Write("Пусто.");

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
// }

// (int, int) Count(int[] arr)
// {
//     int a = 0;
//     int b = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]%2==0) a++;
//         else b++;
//     }
//     return (a, b);
// }

// int[] array = RandArr(new Random().Next(10, 15));
// PrintArr(array);
// Console.Write("В данном массиве чётных и нечётных чисел соответственно: " + Count(array));

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = new Random().Next(0, 200);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
// }

// int Count(int[] arr)
// {
//     int x = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 9 && arr[i] < 100) x++;
//     }
//     return x;
// }

// int[] array = RandArr(123);
// PrintArr(array);
// Console.Write($"количество элементов из отрезка [10,99]: {Count(array)}");

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = new Random().Next(0, 200);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
// }

// int Count(int[] arr)
// {
//     int x = 0;
//     for (int i = 0; i < arr.Length; i+=2) x += arr[i];
//     return x;
// }

// int[] array = RandArr(7);
// PrintArr(array);
// Console.Write($"Сумма чисел, стоящих на нечётной ПОЗИЦИИ: {Count(array)}");

// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] RandArr(int a)
// {
//     int[] arr = new int[a];
//     for (int i = 0; i < a; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
// }

// int[] Count (int[] array)
// {
// int last = array.Length - 1;
// int[] barray = new int[array.Length / 2];
// for (int i = 0; i < (array.Length / 2); i++)
// {
//     barray[i]=array[i]*array[last];
//     last--;
// }
// return barray;
// }

// int[] array = RandArr(11);
// PrintArr(array);
// PrintArr(Count(array));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] MakeArr(int length)
// {
//     double[] arr = new double[length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-100, 100);
//     }
//     return arr;
// }

// double Calc(double[] arr)
// {
//     double min = arr[0];
//     double max = arr[1];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//         if (arr[i] < min) min = arr[i];
//     }
//     return max - min;
// }

// double[] array = MakeArr(5);
// Console.WriteLine(String.Join(", ", array));
// Console.Write(Calc(array));

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

// могу только void методом

// void Fibo(int arg)
// {
//     int a = 0;
//     int b = 1;
//     int c = 0;
//     Console.Write($"{a} {b}");
//     for (int i = 1; i <= arg; i++)
//     {
//         c = a + b;
//         Console.Write(" " + c);
//         a = b;
//         b = c;
//     }
// }

// Fibo(15);

// 46. Написать программу масштабирования фигуры



// 47. Написать программу копирования массива

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
