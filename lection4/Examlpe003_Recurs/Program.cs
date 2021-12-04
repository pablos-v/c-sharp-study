// ## Рекурсия
// 66. Показать натуральные числа от 1 до N, N задано и 67. Показать натуральные числа от N до 1, N задано

// string Show(int N)
// {
//     if (N < 1) return "0";
//     else return Show(N - 1) + " " + N;
// }

// Console.WriteLine(Show(5));

// string ShowN(int n)
// {
//     return n <= 0 ? "0" : $"{ShowN(n - 1)} {n}";
// }

// Console.WriteLine(ShowN1(5));

// string ShowN1(int n) => n <= 0 ? "0" : $"{ShowN1(n - 1)} {n}";

// void Show(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1) Show(n - 1);
// }
// Show(5);

// 68. Показать натуральные числа от M до N, N и M заданы

// string ShowMN1(int m, int n)
// {
//     if (m > n) return m + " " + ShowMN1(m - 1, n);
//     if (m < n) return m + " " + ShowMN1(m + 1, n);
//     return m + "";
// }

// Console.Write(ShowMN1(-2, 5));

// void ShowMtoN(int m, int n)
// {
//     Console.Write($"{m} ");
//     if (m < n) ShowMtoN(m + 1, n);
//     if (m > n) ShowMtoN(m - 1, n);
// }

// ShowMtoN(15,11);

// 69. Найти сумму элементов от M до N, N и M заданы

// int Sum(int M, int N)
// {
//     if (M < N) return M + Sum(M + 1, N);
//     if (M > N) return M + Sum(M - 1, N);
//     else return M;
// }
// Console.Write(Sum(10, 1));

// 70. Найти сумму цифр числа

// int SumNum(int num)
// {
//     if (num == 0) return 0;
//     return (num % 10) + SumNum(num / 10);
// }

// Console.Write(SumNum(12345));

// 71. Написать программу вычисления функции Аккермана

// int A(int m, int n)
// {
//     if (m == 0) return n += 1;
//     if (m > 0 && n == 0) return A(m - 1, 1);
//     if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
//     else return 0;
// }

// Console.Write(A(2,2)); // == 7

// 72. Написать программу возведения числа А в целую степень B

// int Pow(int a, int b)
// {
//     if (b == 1) return a;
//     else return a * Pow(a, b - 1);
// }

// int Pow2(int a, int b) => (b == 1) ? a : a * Pow(a, b - 1);

// Console.Write(Pow2(3, 3));

// 73. Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

// (int a, int b) Enter()
// {
//     while (true)
//     {
//         Console.Write("Введите первые два числа через запятую: ");
//         string[] nums = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
//         if (nums.Length == 2 && int.TryParse(nums[0], out int a) && int.TryParse(nums[1], out int b) && (a < b)) return (a, b);
//         else if (nums.Length == 2 && int.TryParse(nums[0], out int c) && int.TryParse(nums[1], out int d) && (c > d)) return (d, c);
//         else Console.WriteLine("Что-то вы не то ввели, давайте заново.");
//     }
// }

// string Fibo(int n, (int a, int b) start)
// {
//     if (n <= 1) return ($"{start.a + start.b}");

//     return ((start.a + start.b) + " " + Fibo(n - 1, (start.b, start.a + start.b)));
// }

// (int a, int b) start = Enter();
// Console.Write(start.a + " " + start.b + " ");
// Console.Write(Fibo(6, (start.a, start.b)));

// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int Enter()
{
    while (true)
    {
        Console.Write("Сколько букв будет в слове: ");
        if (int.TryParse(Console.ReadLine(), out int b) && b > 0) return b;
        else Console.WriteLine("Что-то вы не то ввели, давайте заново.");
    }
}

string[] alph = { "а", "и", "с", "в" };

void Print(int n, string[] alph)
{
    for (int a = 0; a < alph.Length; a++)
    {
        for (int i = 0; i < alph.Length; i++)
        {
            for (int c = 0; c < alph.Length; c++)
            {
                string res = alph[a] + alph[i] + alph[c];
                Console.Write(res + " ");
            }
        }
    }
}

Print(Enter(), alph);


