This is a small game engine for simple console games.

# Examples:

## 1. Maze Game
```
using GameEngine.Input;
using GameEngine.Main;
using GameEngine.Math;
using GameEngine.UI;

var playerPosition = new Vector(3, 3);

char playerSymbol = 'p';
int playerSpeed = 1;

var player = new Player(playerPosition, playerSymbol);

int score = 0;

var textPosition = new Vector(0, 10);

var scoreText = new Text(textPosition, $"Score: {score}");

Map.Generate();

while (true)
{
    player.Update();
    scoreText.UpdateText($"Score: {score}");

    var playerPositionX = player.Position.X;
    var playerPositionY = player.Position.Y;

    if (Input.IsPressedKey(ConsoleKey.W) && Map.GetChar(playerPositionY - 1, playerPositionX) != '#')
        player.SetPosition(playerPositionY - playerSpeed, playerPositionX);
    else if (Input.IsPressedKey(ConsoleKey.A) && Map.GetChar(playerPositionX, playerPositionX - 1) != '#')
        player.SetPosition(playerPositionY, playerPositionX - playerSpeed);
    else if (Input.IsPressedKey(ConsoleKey.S) && Map.GetChar(playerPositionY + 1, playerPositionX) != '#')
        player.SetPosition(playerPositionY + playerSpeed, playerPositionX);
    else if (Input.IsPressedKey(ConsoleKey.D) && Map.GetChar(playerPositionY, playerPositionX + 1) != '#')
        player.SetPosition(playerPositionY, playerPositionX + playerSpeed);

    if (Map.GetChar(playerPositionY, playerPositionX) == 'x')
    {
        Map.SetNewChar(playerPositionY, playerPositionX, 'o');

        score++;
        scoreText.UpdateText($"Score: {score}");
    }

    Console.ReadKey(true);
    Console.Clear();

    Map.Generate();
}
```

## 2. Randomizer
```
using GameEngine.Math;

while (true)
{
    Console.WriteLine(Randomizer.Generate(0, 100));
    await Task.Delay(200);
}
```
## Classes and their methods:
```
GameEngine.Input:
    static class Input:
        public static ConsoleKey GetKey(ConsoleKey key)
        public static bool IsPressedKey(ConsoleKey key)

GameEngine.Main:
    public abstract class GameObject(Vector position, char? symbol):
        public Vector Position => _position;

        public void SetPosition(int y, int x)
        public void SetPosition(Vector position)
        public virtual void Update()

    public static class Map:
        public static void Generate()
        public static void SetNewChar(int y, int x, char symbol)
        public static char GetChar(int y, int x)
        public static void ChangeMap(char[,] map)
    
    public class Player(Vector vector, char symbol) : GameObject(vector, symbol)

GameEngine.Math:
    public struct Vector(int x, int y)
    public static class Randomizer:
        Generate(int, int)
        Generate(long, long)
        Generate(float, float)
        Generate(double, double)

GameEngine.UI:
    public class Text(Vector position, string content):
        public string Content => content;

        public void UpdateText(string content = "")

```
