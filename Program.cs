Console.WriteLine("Шаг 1. Исходный код.");
int dayNumber = 6;
switch (dayNumber) {
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}


Console.WriteLine();
Console.WriteLine("Шаг 1. Пятница тоже выходной.");
int dayNumber1 = 5;
switch (dayNumber1) {
    case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}


Console.WriteLine();
Console.WriteLine("Шаг 2. Исходный код.");
int score = 78;

switch (score) {
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}


Console.WriteLine();
Console.WriteLine("Шаг 2. С изменением границ.");
int score1 = 59;

switch (score1) {
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}


Console.WriteLine();
Console.WriteLine("Шаг 3. Исходный код.");
int score2 = 78;

string result = score2 switch
{
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};

Console.WriteLine(result);


Console.WriteLine();
Console.WriteLine("Шаг 3. Категория температуры.");
int temperature = 22;

string result1 = temperature switch
{
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко"
};

Console.WriteLine(result1);
