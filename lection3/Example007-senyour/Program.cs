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


int[] RandArr(int a)
{
    int[] arr = new int[a];
    for (int i = 0; i < a; i++)
    {
        arr[i]= new Random().Next(-9,10);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}

(int, int) Sum(int[] arr)
{
    int sump=0;
    int summ=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) sump+=arr[i];
        else summ+=arr[i];
    }
    return (sump, summ);
}

int[] array=RandArr(12);
PrintArr(array);
Console.WriteLine($"Сумма положительных и отрицательных чисел массива соответственно: {Sum(array)}");

// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом