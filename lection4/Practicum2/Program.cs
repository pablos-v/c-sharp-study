
// -----------------практикум 24.11.21-------------------

// Консольная игра "Угадай число"
// Комп загадывает число (в некотором отрезке), у игрока есть несколько попыток, чтобы угадать это число Игрок вводит различные числа, комп считает количество попыток, а также "говорит" введенное число больше или меньше загаданного.

// Нам необходимо задать исходные (обозначить условия). Отрезок (минимальное и максимальное значение), количество попыток. Один способ - задать как константы, второй способ - запросить у игрока.
// Инициализировать игру. Загадываем число и приветсвуем игрока, объясняем условия игры.
// Делаем ход. Запрашиваем и получаем от игрока число. Сравниваем это число с загаданным, изменяем количество попыток и выводим результат.
// Завершение игры (Если человек угадал, либо потратил все попытки). Либо предложить сыграть еще раз.
// GameInit() - метод, который задает все исходные значения в вашей игре.
// MakeMove() - ходы, задаются этим методом.
// RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
// CheckNumber(int PlayesrNumber, int SecretNumber)
// GameOver(bool winner) -


int RequestNumber(string words) // ввод чисел
{
    while (true)
    {
        Console.Write(words);
        if (int.TryParse(Console.ReadLine(), out int num)) return num;
        else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
    }
}

(int count, int secretNumber) GameInit() // задает все исходные значения в игре
{
    Console.WriteLine("Игра УГАДАЙ ЧИСЛО. Я загадаю число, а вы попробуете его отгадать.");
    Console.WriteLine("Для начала нужно указать диапазон чисел для загадывания.");
    int a = RequestNumber("Укажите минимальное значение: ");
    int b = RequestNumber("Укажите максимальное значение: ");
    int count = RequestNumber("Сколько будет попыток: ");
    int secretNumber = new Random().Next(a, b + 1);
    return (count, secretNumber);
}

string CheckNumber(int userVersion, int secretNumber)
{
    if (userVersion > secretNumber) return "меньше";
    else return "больше";
}

void MakeMove((int count, int secretNumber) var)
{
    for (int i = 1; i <= var.count; i++)
    {
        int userVersion = RequestNumber($"Попытка номер {i}, какое число загадано? ");
        if (userVersion == var.secretNumber)
        {
            Console.Clear();
            Console.WriteLine("Вы угадали! Это победа, поздравляю!");
            return;
        }
        else Console.WriteLine($"Неверно, {CheckNumber(userVersion, var.secretNumber)}. Осталось {var.count - i} попыток.");
    }
    Console.Clear();
    Console.WriteLine("Вы проиграли. Давайте сыграем снова!");
    Console.WriteLine();
    MakeMove(GameInit());
}

MakeMove(GameInit());


