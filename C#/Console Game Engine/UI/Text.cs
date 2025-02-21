using GameEngine.Main;
using GameEngine.Math;

namespace GameEngine.UI;

public sealed class Text<T>(Vector position, T content) : GameObject(position, default)
{
    public T Content => content;

    public void UpdateText(T content = default!)
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.WriteLine(content);
    }
}
