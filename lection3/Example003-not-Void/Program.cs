// 0. Вывести квадрат числа

// int f(int x)
// {
//     return x*x;
// }
// Console.WriteLine(f(10));

// 1. По двум введённым числам проверять является ли первое квадратом второго

// int[] Enter()
// {
//     int[] num = new int[2];
//     Console.WriteLine("Введите первое число ");
//     string A = Console.ReadLine();
//     num[0] = int.Parse(A);
//     Console.WriteLine("Введите второе число ");
//     string B = Console.ReadLine();
//     num[1] = int.Parse(B);
//     return num;
// }
// string Sqrt(int[] num)
// {
//     if (num[0] == num[1] * num[1]) return ($"Число {num[0]} является квадратом числа {num[1]}");
//     else return ($"Число {num[0]} не является квадратом числа {num[1]}");
// }
// Console.Write(Sqrt(Enter()));

//  2. Даны два числа. Показать большее и меньшее число

// string Max(int a, int b)
// {
//     if (a>b) return ($"Max = {a}, min = {b}");
//     else return ($"Max = {b}, min = {a}");
// }
// Console.WriteLine(Max(5, 7));

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

//  6. Выяснить является ли число чётным

// string Even(int a)
// {
//    if(a == 0) return ("Введите число, отличное от нуля");
//    else if(a % 2 == 0) return ("Это чётное число");
//    else return ("Это нечётное число");
// }
// Console.WriteLine(Even(16));

//  7. Показать числа от -N до N

// не решил

//  8. Показать четные числа от 1 до N

// не решил

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

