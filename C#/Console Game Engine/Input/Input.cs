namespace GameEngine.Input;

#nullable disable

public static class Input
{
    public static string InputFromKeyboard(string tip = "", char seperator = '\0')
    {
        PrintTip($"{tip}{seperator}");

        var value = Console.ReadLine();

        return value;
    }

    public static ConsoleKey GetKey(ConsoleKey key) => key;
    public static bool IsPressedKey(ConsoleKey key) => key == Console.ReadKey(true).Key;

    private static void PrintTip(string tip) => Console.Write(tip);
}
