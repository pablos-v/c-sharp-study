
int factWhile(int value)
{
    int x = 1;
    while (value != 1)
    {
        x = x * value;
        value--;
    }
    return x;
}

Console.Write("Введите значение для вычисления факториала: ");
string valueS = Console.ReadLine();
int value = int.Parse(valueS);

if (value <= 0)
{
    Console.Write("Значение факториала не может быть меньше 1. Перезапустите программу.");
    Environment.Exit(0);
}

Console.Write($"Факториал {value} равен {factWhile(value)}");