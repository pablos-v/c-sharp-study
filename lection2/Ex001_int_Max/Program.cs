int[] massive = { 22457, 4, 664, 23, 55, 78, 952, 3455, 2224, 221, 234, 567 };
int Max(int[] mass)
{
    int count = 0;
    int maxi = mass[count];
    while (count < mass.Length)
    {
        if (maxi < mass[count])
        {
            maxi = mass[count];
        }
        count++;
    }
    return maxi;
}
Console.Write(Max(massive));