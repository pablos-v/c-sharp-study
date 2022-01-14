// ------------------find min index in sorted array with binary search----------

// int[] array = { 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 };

// int FindMinIndex(int[] arr)
// {
//     int left = 0, right = arr.Length - 1, mid = -1;
//     while (Math.Abs(left - right) != 1)
//     {
//         mid = (right + left) / 2;
//         if (arr[left] < arr[right]) right = mid;
//         else left = mid;
//     }
//     if (mid == left) return right;
//     else return left;
// }

// Console.Write(FindMinIndex(array));


// ------------- write Mario tower from CS50

// void Mario() //1st version
// {
//     int n = 0;
//     while (n <= 0)
//     {
//         Console.WriteLine("Введите высоту блоков: ");
//         if (int.TryParse(Console.ReadLine(), out int m)) n = m;
//     }
//     for (int f = 1; f < n + 1; f++)
//     {
//         for (int i = 0; i < n - f; i++) Console.Write(" ");
//         for (int i = 0; i < f; i++) Console.Write("#");
//         Console.Write("\n");
//     }
// }

// Mario();

// -------------------1.5 version with recursion-----------------------

// void Mario(int n)
// {
//     if (n == 0) return;
//     Mario(n - 1);
//     for (int i = 0; i < n; i++) Console.Write("#");
//     Console.Write("\n");
// }

// Mario(5);

// --------------2nd version Mario-----------------

// string Loop(string a, int num)
// {
//     string h = string.Empty;
//     for (int i = 0; i < num; i++) h += a;
//     return h;
// }

// void Mario()
// {
//     int n = 0;
//     while (n <= 0)
//     {
//         Console.WriteLine("Введите высоту блоков: ");
//         if (int.TryParse(Console.ReadLine(), out int m)) n = m;
//     }

//     for (int f = 1; f < n + 1; f++)
//     {
//         string row = Loop(" ", n - f) + Loop("#", f) + Loop(" ", 2) + Loop("#", f) + Loop(" ", n - f);
//         Console.Write(row + "\n");
//     }
// }

// Mario();


//-------------Credit card validation (by Luhn’s Algorithm)--------

// long[] EnterCardNum()
// {
//     while (true)
//     {
//         Console.WriteLine("Введите номер кредитной карты: ");
//         string a = Console.ReadLine();
//         int l = a.Length;
//         if (l >= 13 && l <= 16 && long.TryParse(a, out long m))
//         {
//             long[] arr = new long[l];
//             for (int i = l - 1; i >= 0; i--)
//             {
//                 arr[i] = m % 10;
//                 m /= 10;
//             }
//             return arr;
//         }
//         else Console.WriteLine("Номер введён не правильно!\n");
//     }
// }

// bool IsValid(long[] array)
// {
//     long sum = 0;
//     for (int i = array.Length - 2; i >= 0; i -= 2)
//     {
//         long x = array[i] * 2;
//         if (x / 10 != 0) sum += (x % 10) + (x / 10);
//         else sum += x;
//     }
//     for (int i = array.Length - 1; i >= 0; i -= 2)
//     {
//         sum += array[i];
//     }
//     Console.WriteLine("Контрольная цифра " + sum);
//     return sum % 10 == 0;
// }

// if (IsValid(EnterCardNum())) Console.Write("Номер кредитной карты подлинный!");
// else Console.Write("Кредитной карты с таким номером НЕ СУЩЕСТВУЕТ.");

//------------------------------------------



