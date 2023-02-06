using Spectre.Console;

namespace ConsoleEconGame.Confirmations;

public static class Confirmations
{
    public static bool AcceptPersonaConfirmation()
    {
        if (AnsiConsole.Confirm("Do you accept?")) return true;
        
        AnsiConsole.MarkupLine("Oh okay :(");
        return false;

    }
}