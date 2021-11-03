Console.Write("Введите скорость первого друга: ");
string firstFriendSpeed1 = Console.ReadLine();
int firstFriendSpeed = int.Parse(firstFriendSpeed1);

Console.Write("Введите скорость второго друга: ");
string secondFriendSpeed1 = Console.ReadLine();
int secondFriendSpeed = int.Parse(secondFriendSpeed1);

Console.Write("Введите скорость собачки: ");
string dogSpeed1 = Console.ReadLine();
int dogSpeed = int.Parse(dogSpeed1);

Console.Write("А какое расстояние между друзьями: ");
string distance1 = Console.ReadLine();
double distance = double.Parse(distance1);

int count = 0;
//double distance = 10000;
//int firstFriendSpeed = 1;
//int secondFriendSpeed = 2;
//int dogSpeed = 5;
int friend = 2;
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
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");