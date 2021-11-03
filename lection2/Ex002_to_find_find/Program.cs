int[] arrayF = { 3, 55, 7, 88, 5, 23, 54, 566, 7889, 12, 34 };
int find=23;
int index=0;
while (index<arrayF.Length)
{
    if (arrayF[index]==find) break;
    index++;
}
Console.Write(index);