// Сформировать случайным образом N-элементный массив, 
// заполненный однозначными целыми числами разных знаков.
// Задать k и выяснить:
// - сколько раз повторяется k в массиве
// - сколько элементов находится между первым и последним k

void fillArray(int[] array2fill)
{
    int i = 0;
    while (i < array2fill.Length) array2fill[i++] = new Random().Next(-9, 10);
}

void printIt(int[] ar2print, int k)
{
    int i = 0;
    Console.Write("В сгенерированном массиве чисел: ");
    while (i < ar2print.Length) Console.Write(ar2print[i++] + " ");
    Console.Write($"\nЗначение переменной k равное {k}");
}

void check(int k, int[] arra, int[] indexArray)
{
    if (k > -10 && k < 10)
    {
        printIt(arra, k);
        int n = 0;
        int i = 0;
        while (i < arra.Length)
        {
            if (arra[i] == k)
            {
                indexArray[n] = i;
                n++;
            }
            i++;
        }
        if (n == 0) Console.WriteLine(", не встречается.");
        else if (n == 1) Console.WriteLine(", встречается единожды.");
        else
        {
            int x = indexArray[n - 1] - indexArray[0] - 1;
            Console.WriteLine($", встречается {n} раз. Между первым и последним {x} чисел.");
        }
    }
    else Console.WriteLine("Допустимый диапазон значений от -9 до +9 !!! Перезапустите программу.");
}

int[] array = new int[new Random().Next(20, 40)];
fillArray(array);
Console.Write("Введите значение k:");
string ks = Console.ReadLine();
int k = int.Parse(ks);
int[] indexArray = new int[array.Length]; // Изначально хотел создать пустой массив и складывать 
//в него индексы чисел, равных k. В JS такое вроде делал, в C# видимо невозможно так. 
//Только массив заранее заданного размера... Может есть более изящное решение? Буду рад критике. Спасибо!
check(k, array, indexArray);