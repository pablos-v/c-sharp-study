// Задача: 2 друга идут навстречу друг другу. Пока они идут, собака бегает от одного к другому.
// Сколько раз собака пробежит от одного к другому на момент встречи друзей?
int InputMethod(string s)
{
    while (true)
    {
        Console.Write(s);
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0) return n;
        else Console.WriteLine("Некорректное значение, давайте снова.");
    }
}
int Counter()
{
    int firstFriendSpeed = InputMethod("Введите скорость первого друга: ");
    int secondFriendSpeed = InputMethod("Введите скорость второго друга: ");
    int dogSpeed = InputMethod("Введите скорость собаки: ");
    double distance = InputMethod("А какое расстояние между друзьями: ");
    int count = 0, friend = 2;
    double time = 0;
    while (distance > 10)
    {
        if (friend == 1)
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2;
        }
        else
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
        }
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    return count;
}

Console.Write("Собака пробежит " + Counter() + " раз.");
