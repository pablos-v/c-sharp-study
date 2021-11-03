(double, double) goo;
(double, double) CounItPlease(double a, double b, double c)
{
    double D = b * b - 4 * a * c;
    if (D < 0)
    {
        return (double.NaN, double.NaN);
    }
    else
    {
        double s1 = (-b + Math.Sqrt(D)) / (2 * a);
        double s2 = (-b - Math.Sqrt(D)) / (2 * a);
        return (s1, s2);
    }
}
goo = CounItPlease(1,0,6); Console.WriteLine(goo);
goo = CounItPlease(1,2,-4); Console.WriteLine(goo);
goo = CounItPlease(1,0,-4); Console.WriteLine(goo);