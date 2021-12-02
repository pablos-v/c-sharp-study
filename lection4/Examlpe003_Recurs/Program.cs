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

int SumNum(int num)
{
    if (num == 0) return 0;
    else return (num % 10) + SumNum(num / 10);
}

Console.Write(SumNum(4567));

// 71. Написать программу вычисления функции Аккермана
// 72. Написать программу возведения числа А в целую стень B
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
