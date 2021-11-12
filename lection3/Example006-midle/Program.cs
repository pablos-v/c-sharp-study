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

// int[] F23(int n)
// {
//     int[] arr = new int[n];
//     for (int i = 1; i <= arr.Length; i++)
//     {
//         arr[i-1] = i*i;
//     }
//     return arr;
// }
// Console.WriteLine(string.Join(", ", F23(5)));

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

// int F23(int A)
// {
//     int arr = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         arr += i;
//     }
//     return arr;
// }
// Console.WriteLine(F23(10));

// 26. Возведите число А в натуральную степень B используя цикл



// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

