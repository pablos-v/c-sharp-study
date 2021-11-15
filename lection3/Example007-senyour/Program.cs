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

// bool Search(int[] arr, int N)
// {
//     bool x=false;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]==N) x=true;        
//     }
//     return x;
// }

// int[] array=RandArr(new Random().Next(10,15));
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
//     int i = 0;
//     while (i < arr.Length)
//     {
//         x += arr[i];
//         i = i + 2;
//     }
//     return x;
// }

// int[] array = RandArr(7);
// PrintArr(array);
// Console.Write($"Сумма чисел, стоящих на нечётной ПОЗИЦИИ: {Count(array)}");

// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] RandArr(int a)
{
    int[] arr = new int[a];
    for (int i = 0; i < a; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(" ");
}

int[] array = RandArr(11);

PrintArr(array);

int last = array.Length - 1;
int[] barray = new int[array.Length / 2];
for (int i = 0; i < (array.Length / 2); i++)
{
    barray[i]=array[i]*array[last];
    last--;
}

PrintArr(barray);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом