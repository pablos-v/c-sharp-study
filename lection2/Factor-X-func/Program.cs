int fact(int value)
{
    if (value == 1) return 1;
    else
    {
        value = value * fact(value-1);
        return value;
    }
}

Console.Write("Введите значение для вычисления факториала: ");
string valueS = Console.ReadLine();
int value = int.Parse(valueS);

if (value <= 0)
    {
        Console.Write("Значение факториала не может быть меньше 1. Перезапустите программу.");
        Environment.Exit(0);
    }

Console.Write($"Факториал {value} равен {fact(value)}");
