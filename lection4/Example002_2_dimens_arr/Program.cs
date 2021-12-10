
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
//         string[] enter = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
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

// int[,] Sorted(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int size = array.GetLength(1);
//         while (size > 1)
//         {
//             int maxindex = 0;
//             for (int j = 0; j < size; j++) if (array[i, j] > array[i, maxindex]) maxindex = j;
//             int buffer = array[i, size - 1];
//             array[i, size-- - 1] = array[i, maxindex];
//             array[i, maxindex] = buffer;
//         }
//     }
//     return array;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.ReadLine();
// PrintArray(Sorted(arr));

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
//         if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
//         int.TryParse(enter[1], out int n))
//         {
//             if (m == n) return (m, n);
//             else Console.WriteLine("Мы сможем транспонировать только квадратную матрицу.");
//         }
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

// int[,] Trans(int[,] arr)
// {
//     int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr2[j, i] = arr[i, j];
//         }
//     }
//     return arr2;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.ReadLine();
// PrintArray(Trans(arr));

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

// (int m, int n) Len() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

// int MinSumNumber(int[,] arr)
// {
//     int[] summArray = new int[arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) summArray[i] += arr[i, j];
//     }
//     int result = 0;
//     for (int i = 1; i < arr.GetLength(0); i++) if (summArray[i] < summArray[result]) result = i;
//     return result;
// }

// int[,] arr = RandArray(Len());
// PrintArray(arr);
// Console.WriteLine($"Строка с наименьшей суммой элементов: {(MinSumNumber(arr) + 1)}, если считать с единицы.");

// 60. Составить частотный словарь элементов двумерного массива

// (int m, int n) Lenth() // задать массив
// {
//     while (true)
//     {
//         Console.Write("Введите количество строк и столбцов массива через запятую: ");
//         string[] enter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

// void PrintVocab(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         if (arr[i, 0] != 0) Console.WriteLine($"Число {arr[i, 0]} встречается {arr[i, 1]} раз.");
//     }
// }

// bool CheckIfThereNumber(int[,] arr, int m, out int n)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         if (arr[i, 0] == m)
//         {
//             n = i;
//             return true;
//         }
//     }
//     n = 0;
//     return false;
// }

// int[,] FrequencyVocabulary(int[,] arr)
// {
//     int[,] vocab = new int[arr.Length, 2];
//     int vocabRow = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (CheckIfThereNumber(vocab, arr[i, j], out int n)) vocab[n, 1] += 1;
//             else
//             {
//                 vocab[vocabRow, 0] = arr[i, j];
//                 vocab[vocabRow++, 1] += 1;
//             }
//         }
//     }
//     return vocab;
// }

// int[,] array = RandArray(Lenth());
// PrintArray(array);
// PrintVocab(FrequencyVocabulary(array));

// 61. Найти произведение двух матриц

// (int m, int n) Len(int num) // задать массив
// {
//     while (true)
//     {
//         Console.Write($"Введите количество строк и столбцов {num} матрицы через запятую: ");
//         string[] enter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

// int[,] MultiplyMatrix(int[,] A, int[,] B)
// {
//     int[,] result = new int[A.GetLength(0), B.GetLength(1)];
//     for (int i = 0; i < A.GetLength(0); i++)
//     {
//         for (int f = 0; f < A.GetLength(0); f++)
//         {
//             for (int j = 0; j < B.GetLength(0); j++)
//             {
//                 result[i, f] += A[i, j] * B[j, f];
//             }
//         }
//     }
//     return result;
// }

// (int[,] A, int[,] B) CreateMatrices()
// {
//     while (true)
//     {
//         int[,] arrayA = RandArray(Len(1));
//         int[,] arrayB = RandArray(Len(2));
//         if (arrayA.GetLength(0) == arrayB.GetLength(1) || arrayA.GetLength(1) == arrayB.GetLength(0)) return (arrayA, arrayB);
//         Console.WriteLine("Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк B.");
//     }
// }

// (int[,] A, int[,] B) matrices = CreateMatrices();
// PrintArray(matrices.A);
// Console.WriteLine("-----");
// PrintArray(matrices.B);
// Console.WriteLine("---Результат умножения матриц: ---");
// PrintArray(MultiplyMatrix(matrices.A, matrices.B));

// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

(int m, int n) Len() // задать массив
{
    while (true)
    {
        Console.Write("Введите количество строк и столбцов массива через запятую: ");
        string[] enter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (enter.Length == 2 && int.TryParse(enter[0], out int m) &&
        int.TryParse(enter[1], out int n)) return (m, n);
        else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
    }
}

int[,] RandArray((int m, int n) mn)
{
    int[,] array = new int[mn.m, mn.n];
    for (int i = 0; i < mn.m; i++)
    {
        for (int j = 0; j < mn.n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

(int row, int column) MinIndex(int[,] arr)
{
    int a = 0, b = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[a, b])
            {
                a = i;
                b = j;
            }
        }
    }
    return (a, b);
}

int[,] NewArrayCorrected(int[,] arr, (int a, int b) index)
{
    int[,] newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int row = 0, column = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == index.a) continue;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == index.b) continue;

            newArray[row, column] = arr[i, j];
            column += 1;
        }
        row += 1;
        column = 0;
    }
    return newArray;
}
int[,] array = RandArray(Len());
PrintArray(array);
(int a, int b) qwer = MinIndex(array);
Console.WriteLine(qwer.a + " " + qwer.b);
PrintArray(NewArrayCorrected(array, (qwer.a, qwer.b)));

// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 64. Показать треугольник Паскаля (на 15 и 20 строк)
// *Сделать вывод в виде равнобедренного треугольника

// int Len() // задать высоту треугольника
// {
//     while (true)
//     {
//         Console.Write("Введите высоту треугольника Паскаля: ");
//         if (int.TryParse(Console.ReadLine(), out int n) && n > 4) return n;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] == 0) Console.Write(" ");
//             else if (arr[i, j] > 999) Console.Write(arr[i, j] + " ");
//             else if (arr[i, j] > 99) Console.Write(arr[i, j] + "  ");
//             else if (arr[i, j] > 9) Console.Write(arr[i, j] + "   ");
//             else if (arr[i, j] > 0) Console.Write(arr[i, j] + "    ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] PascalTriangle(int n)
// {
//     int[,] array = new int[n, 3 * n - 6]; // 3*n-6 высчитал эмпирически
//     int centralColumn = array.GetLength(1) / 2;
//     array[0, centralColumn] = 1; // вершина треугольника
//     for (int i = 1; i < array.GetLength(0); i++) // заполняем единицами контур
//     {
//         array[i, centralColumn + i] = 1;
//         array[i, centralColumn - i] = 1;
//     }

//     for (int i = 2; i < array.GetLength(0); i++) // заполняем со 2 ряда
//     {
//         if (i % 2 == 0) InnerCounter(array, i, centralColumn);
//     }
//     return array;
// }

// void InnerCounter(int[,] array, int rowNum, int centralColumn)
// {
//     int count = 0;
//     for (int i = rowNum; i < array.GetLength(0); i++) // заполняем со 2 ряда
//     {
//         array[i, centralColumn + count] = array[i - 1, centralColumn + count + 1] + array[i - 1, centralColumn + count - 1];
//         array[i, centralColumn - count] = array[i - 1, centralColumn - count + 1] + array[i - 1, centralColumn - count - 1];
//         count++;
//     }
// }

// PrintArray(PascalTriangle(Len()));

// 65. Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

// 99. На рекурсию сложная, вначале блок-схему
// создать алгоритм для игры в ХАНОЙСКИЕ БАШНИ, который будет писать последовательность действий
