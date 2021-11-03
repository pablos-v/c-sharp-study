// Таблица умножения

// for (int i = 2; i < 10; i++)
// {
//     for (int f = 2; f <= 10; f++)
//     {
//         Console.WriteLine($"{i} X {f} = {f*(i)}");
//     }
//     Console.WriteLine(" ");
// }
// --------------------------
// Дан текст. В тексте нужно заменить все пробелы на | , маленькие п заменить на П , 
// большие К заменить на маленькие к.

// string textt = "Дан текст. В тексте нужно заменить все пробелы на | , маленькие п заменить на П , большие К заменить на маленькие к.";

// string replace(string textt, char one, char two)
// {
//     string resultt = String.Empty;
//     for (int i = 0; i < textt.Length; i++)
//     {
//         if (textt[i] == one) resultt = resultt + two;
//         else resultt = resultt + textt[i];
//     }
//     return resultt;
// }
// Console.WriteLine(replace(textt, ' ', '|'));
// Console.WriteLine(replace(textt, 'п', 'П'));
// Console.WriteLine(replace(textt, 'К', 'к'));
// ---------------------------------
//Сортировка выбором по моему алгоритму от макс к мин, с конца к началу

int[] arr = { 10, 5, 6, 4, 3, 2, 9, 1, 1, 4, 4, 7, 8 };

void printArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] SelectSort(int[] array)
{
    int size = array.Length;
    int saved;
    while (size != 1)
    {
        int indMax = 0;
        for (int i = 1; i < size; i++)
        {
            if (array[i] > array[indMax]) indMax = i;
        }
        saved = array[indMax];
        array[indMax] = array[size - 1];
        array[size - 1] = saved;
        size--;
    }
    return array;
}

printArr(arr);
printArr(SelectSort(arr));

// Сортировка выбором вариант Срегея

// int[] arr = { 10, 5, 6, 4, 3 };

// void printArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SelectSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minIndex = 0;
//         for (int f = i + 1; f < array.Length - 1; f++)
//         {
//             if (array[f] < array[minIndex]) minIndex = f;
//         }
//         int saved = array[i];
//         array[i] = array[minIndex];
//         array[minIndex] = saved;
//     }
// }

// printArr(arr);
// SelectSort(arr);
// printArr(arr);
