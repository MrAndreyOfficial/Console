using GameEngine.Math;

namespace GameEngine.Main;

public abstract class GameObject(Vector position, char? symbol)
{
    private Vector _position = position;

    private readonly char? _symbol = symbol;

    public Vector Position => _position;

    public void SetPosition(int y, int x)
    {
        _position.Y = y;
        _position.X = x;
    }

    public void SetPosition(Vector position) => _position = position;

    public virtual void Update()
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.WriteLine(_symbol);
    }
}
