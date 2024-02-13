// See https://aka.ms/new-console-template for more information

PrintBlue("Менеджер учета офисной мебели:");
PrintHelp();









void PrintHelp()
{
    PrintBlue("Список команд:");
    PrintDarkMagenta("1 - Добавить запись (О новой мебели),");
    PrintDarkMagenta("2 - Удалить запись(О списанной мебели),");
    PrintDarkMagenta("3 - Получить список всех записей,");
    PrintDarkMagenta("4 - Получить список записей за месяц,");
    PrintDarkMagenta("5 - Получить сумму записей за конкретный день,");
    PrintDarkMagenta("6 - Очистить все записи,");
    PrintDarkMagenta("7 - Очистить консоль,");
    PrintDarkMagenta("help -помощь.");
}

    void PrintDarkMagenta(string message)
{
    ConsoleColor color = Console.ForegroundColor; 
    Console.ForegroundColor = ConsoleColor.DarkMagenta;   
    Console.WriteLine(message);                   
    Console.ForegroundColor = color;              
}
void PrintGreen(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}
void PrintDarkRed(string message)
{
    ConsoleColor color = Console.ForegroundColor; 
    Console.ForegroundColor = ConsoleColor.DarkRed; 
    Console.WriteLine(message);                   
    Console.ForegroundColor = color;            
}
void PrintBlue(string message)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}

