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

bool Boo(bool X, bool Y)
{
    return ((!(X || Y)) == (!X && !Y));
}

if (Boo(true, true) && Boo(true, false) && Boo(false, true) && Boo(false, false)) Console.WriteLine("Утверждение истинно.");
else Console.WriteLine("Утверждение ложно.");

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндром.
// 22. Найти расстояние между точками в пространстве 2D/3D


