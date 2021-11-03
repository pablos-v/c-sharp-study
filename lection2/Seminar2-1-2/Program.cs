// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// возрастания
// элементы, больше 8
// знакочередования

void fillArray(int[] A, int minValue, int maxValue)
{
    int i = 0;
    while (i < A.Length) A[i++] = new Random().Next(minValue, maxValue + 1);
}

void printArray(int[] A)
{
    int i = 0;
    while (i < A.Length) Console.Write($"{A[i++]} ");
}

void checkValue(int minValue, int maxValue)
{
    if (maxValue <= minValue)
    {
        Console.WriteLine("MAX должно быть болше, чем MIN! Перезапустите программу.");
        Environment.Exit(0);
    }
}

void growing(int[] A)
{
    int[] b = new int[A.Length];
    int i = 1;
    int ib = 1;
    int min = A[0];
    b[0] = A[0];
    while (i < A.Length)
    {
        if (A[i] > min)
        {
            b[ib++] = A[i];
            min = A[i];
        }
        i++;
    }
    int[] B = new int[ib];
    i = 0;
    while (i < B.Length) B[i] = b[i++];
    Console.Write("\nМассив элементов, идущих по возрастанию: ");
    printArray(B);
}

void isBigger8(int[] A)
{
    int[] b = new int[A.Length];
    int i = 0;
    int ib = 0;
    while (i < A.Length)
    {
        if (A[i] > 8) b[ib++] = A[i];
        i++;
    }
    int[] B = new int[ib];
    i = 0;
    while (i < B.Length) B[i] = b[i++];
    Console.Write("\nМассив элементов больше 8: ");
    printArray(B);
}

void signChange(int[] A)
{
    int[] b = new int[A.Length];
    int i = 1;
    int ib = 1;
    int sign;
    b[0] = A[0];
    if (A[0] >= 0) sign = 1;
    else sign = -1;
    while (i < A.Length)
    {
        if (A[i] > 0 && sign == -1)
        {
            b[ib++] = A[i];
            sign = 1;
        }
        else if (A[i] < 0 && sign == 1)
        {
            b[ib++] = A[i];
            sign = -1;
        }
        i++;
    }
    int[] B = new int[ib];
    i = 0;
    while (i < B.Length) B[i] = b[i++];
    Console.Write("\nМассив элементов с чередующимися знаками: ");
    printArray(B);
}

int[] A = new int[30];

Console.Write("Введите MIN значение: ");
string minV = Console.ReadLine();
int minValue = int.Parse(minV);

Console.Write("Введите MAX значение: ");
string maxV = Console.ReadLine();
int maxValue = int.Parse(maxV);

checkValue(minValue, maxValue);
fillArray(A, minValue, maxValue);
Console.Write("Заданный массив: ");
printArray(A);
growing(A);
isBigger8(A);
signChange(A);