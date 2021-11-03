void FillArray(int[] array2fill)
{
    int i = 0;
    while (i < array2fill.Length) array2fill[i++] = new Random().Next(1, 50);
    // {
    //     array2fill[i++] = new Random().Next(1, 50);
    //     //i++;
    // }
}

void PrintIt(int[] ar2print)
{
    int i = 0;
    while (i < ar2print.Length)
    {
        Console.Write(ar2print[i++] + " ");
        //i++;
    }
}

int Max(int[] findHere, int findnum)
{
    int place = 0;
    int ans = -1;
    while (place < findHere.Length)
    {
        if (findHere[place] == findnum)
        {
            ans = place;
            break;
        }
        place++;
    }
    return ans;
}

void awa(int a)
{
    if (a == -1)
    {
        Console.WriteLine("There is no such number :(");
    }
    else
    {
        Console.WriteLine("And the place is: " + a);
    }
}

int[] array = new int[20];
int find = new Random().Next(1, 50);
FillArray(array);
Console.WriteLine("We are looking in the array: ");
PrintIt(array);
Console.WriteLine("\na place of a number: " + find);
awa(Max(array, find));