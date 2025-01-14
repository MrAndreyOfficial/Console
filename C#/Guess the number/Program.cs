using GameEngine.UI;
using GameEngine.Math;

const int startAttempts = 5;

int attempts = startAttempts;

const int minNumber = 0;
const int maxNumber = 10;

var randomNumber = Randomizer.Generate(minNumber, maxNumber);

var attemptsTextPosition = new Vector(0, 0);
var attemptsText = new Text(attemptsTextPosition, string.Empty);

var tipTextPosition = new Vector(0, 3);
var tipText = new Text(tipTextPosition, $"Enter number between {minNumber} and {maxNumber}");

var winTextPosition = new Vector(0, 0);
var winText = new Text(winTextPosition, "You win :D");

var loseTextPosition = new Vector(0, 0);
var loseText = new Text(loseTextPosition, "You lose :(");

var continueTextPosition = new Vector(0, 1);
var continueText = new Text(continueTextPosition, "Continue? y (lowercase and uppercase) - yes; other - no: ");

while (true)
{
    Console.Clear();

    tipText.UpdateText(tipText.Content);
    attemptsText.UpdateText($"Attempts: {attempts}");

    try
    {
        var userNumber = int.Parse(Console.ReadLine()!);

        if (userNumber == randomNumber)
        {
            Console.Clear();

            winText.UpdateText(winText.Content);
            continueText.UpdateText(continueText.Content);
        }

        attempts--;

        if (attempts <= 0)
        {
            Console.Clear();

            loseText.UpdateText(loseText.Content);
            continueText.UpdateText(continueText.Content);
        }

        if (randomNumber == userNumber || attempts <= 0)
        {
            var userChoose = Console.ReadLine();

            if (!userChoose!.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                break;

            ResetGame();
            continue;
        }
    }
    catch (FormatException)
    {
        continue;
    }
}

void ResetGame()
{
    attempts = startAttempts;
    randomNumber = Randomizer.Generate(minNumber, maxNumber);
}
