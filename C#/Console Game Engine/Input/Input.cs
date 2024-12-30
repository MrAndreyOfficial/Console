namespace GameEngine.Input;

public static class Input
{
    public static ConsoleKey GetKey(ConsoleKey key) => key;
    public static bool IsPressedKey(ConsoleKey key) => key == Console.ReadKey(true).Key;
}
