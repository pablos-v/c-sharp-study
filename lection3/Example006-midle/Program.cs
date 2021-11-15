// // Быстрая Сортировка
// //метод для обмена элементов массива
// void Swap(ref int x, ref int y)
// {
//     var t = x;
//     x = y;
//     y = t;
// }

// //метод возвращающий индекс опорного элемента
// int Partition(int[] array, int minIndex, int maxIndex)
// {
//     int pivot = minIndex - 1;
//     for (int i = minIndex; i < maxIndex; i++)
//     {
//         if (array[i] < array[maxIndex])
//         {
//             pivot++;
//             Swap(ref array[pivot], ref array[i]);
//         }
//     }

//     pivot++;
//     Swap(ref array[pivot], ref array[maxIndex]);
//     return pivot;
// }

// //быстрая сортировка
// int[] QuickSort(int[] array, int minIndex, int maxIndex)
// {
//     if (minIndex >= maxIndex)
//     {
//         return array;
//     }

//     int pivotIndex = Partition(array, minIndex, maxIndex);
//     QuickSort(array, minIndex, pivotIndex - 1);
//     QuickSort(array, pivotIndex + 1, maxIndex);

//     return array;
// }

// int[] a={5,6,7,1};
// Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(a, 0, a.Length - 1)));

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
//     for (int i = N; i <= F; i++)
//     {
//         if (i % 2 == 0) m++;
//     }
//     int[] num = new int[m];
//     m = 0;
//     for (int i = N; i <= F; i++)
//     {
//         if (i % 2 == 0)
//         {
//             num[m] = i * i * i;
//             m++;
//         }
//     }
//     return num;
// }
// Console.WriteLine(string.Join(", ", F23(10, 20)));