Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Как же мы тебе рады, Марусенька!");
}
else
{
    Console.WriteLine("Здравствуйте, " + username);
    Console.Write($"Здравствуйте, {username}"); //конкатинация
};