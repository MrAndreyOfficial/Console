using GameEngine.Main;
using GameEngine.Math;

namespace GameEngine.UI;

public class Text(Vector position, string content) : GameObject(position, default)
{
    public string Content => content;

    public void UpdateText(string content = "")
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.WriteLine(content);
    }
}
