void countDown(int i)
{
    Console.Write($"{i} ");
    if (i>0) countDown(i-1);
}
countDown(10);