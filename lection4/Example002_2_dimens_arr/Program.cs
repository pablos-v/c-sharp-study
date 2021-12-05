
// ## Двумерные массивы
// 48. Показать двумерный массив размером m×n заполненный целыми числами

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) && 
//         int.TryParse(enter[1], out int n)) return (m,n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(-9, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(RandArray(Len()));

// 49. Показать двумерный массив размером m×n заполненный вещественными числами

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) && 
//         int.TryParse(enter[1], out int n)) return (m,n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// double[,] RandArray((int m, int n) mn)
// {
//     double[,] array = new double[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = Math.Round((new Random().NextDouble() * 100),2);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(RandArray(Len()));

// 50. В двумерном массиве n×k заменить четные элементы на противоположные
// по знаку?

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(-9, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ReversEven(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] % 2 == 0) arr[i, j] *= -1;
//         }
//     }
//     return arr;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.WriteLine();
// PrintArray(ReversEven(arr));

// 51. Задать двумерный массив следующим правилом: arr[m,n] = m + n.

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] FillArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = i+j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(FillArray(Len()));

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(-9, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ReverseEvenIndex(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= Math.Abs(arr[i, j]);
//         }
//     }
//     return arr;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// PrintArray(ReverseEvenIndex(arr));

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.WriteLine("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(-20, 21);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int RequestNumber() // ввод чисел
// {
//     while (true)
//     {
//         Console.Write("Какое число ищем:");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// (int m, int n) Check(int[,] arr, int num)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             if (arr[i, k] == num) return (i, k);
//         }
//     }
//     return (-1, -1);
// }

// void Out((int m, int n) num)
// {
//     if (num.m == -1) Console.WriteLine("Нет такого.");
//     else Console.WriteLine($"Выбранное вами число нахоится в строке {num.m}, столбце {num.n}.");
//     Console.WriteLine();
// }

// int[,] arr = RandArray(Len());
// Out(Check(arr, RequestNumber()));
// PrintArray(arr);

// 54. В матрице чисел найти сумму элементов главной диагонали

// int Len() // задать матрицу
// {
//     while (true)
//     {
//         Console.WriteLine("Укажите длину стороны матрицы чисел: ");
//         if (int.TryParse(Console.ReadLine(), out int n)) return n;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray(int n)
// {
//     int[,] array = new int[n, n];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumDiag(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, i];
//     }
//     return sum;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.WriteLine();
// Console.WriteLine("Сумма элементов главной диагонали: " + SumDiag(arr));

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] Average(int[,] arr)
// {
//     double[] result = new double[arr.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int f = 0; f < arr.GetLength(0); f++)
//         {
//             result[i] += arr[f, i];
//         }
//         result[i] = Math.Round(Convert.ToDouble(result[i]) / arr.GetLength(0), 2);
//     }
//     return result;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.Write("Среднее арифметическое столбцов: " + string.Join(' ', Average(arr)));

// 56. Написать программу, которая обменивает элементы первой строки и последней строки

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Swap(int[,] arr)
// {
//     int sw = 0;
//     int last = arr.GetLength(0)-1;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         sw = arr[0, i];
//         arr[0, i] = arr[last,i];
//         arr[last,i] =sw;
//     }
//     return arr;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.WriteLine();
// PrintArray(Swap(arr));

// 57. Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n)) return (m, n);
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// int[,] RandArray((int m, int n) mn)
// {
//     int[,] array = new int[mn.m, mn.n];
//     for (int i = 0; i < mn.m; i++)
//     {
//         for (int j = 0; j < mn.n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }



// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// 60. Составить частотный словарь элементов двумерного массива
// 61. Найти произведение двух матриц
// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 64. Показать треугольник Паскаля (на 20 строк)
// *Сделать вывод в виде равнобедренного треугольника
// 65. Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

//  На рекурсию сложная, вначале блок-схему
// создать алгоритм для игры в ханойские башни, который будет писать последовательность действий
