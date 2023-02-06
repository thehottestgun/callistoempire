using ConsoleEconGame.Enums;
using ConsoleEconGame.Messages;
using Spectre.Console;

namespace ConsoleEconGame.Flows;

public abstract class GameStartFlow
{
    public static void ExecuteGameStartFlow()
    {
/*
 * TODO: Add length validation for player name.
 */
        var playerName = AnsiConsole.Ask<string>(PlayerBuilderMessages.AskForName);
        var playerAge = 0;


        playerAge = AnsiConsole.Prompt(
            new TextPrompt<int>(PlayerBuilderMessages.AskForAge)
                .PromptStyle("red")
                .ValidationErrorMessage(ValidationErrors.InvalidAgeInput)
                .Validate(age =>
                {
                    return age switch
                    {
                        <= 0 => ValidationResult.Error(ValidationErrors.AgeTooLowError),
                        >= 99 => ValidationResult.Error(ValidationErrors.AgeTooHighError),
                        _ => ValidationResult.Success()
                    };
                }));
        AnsiConsole.Markup(GeneralMessages.StartBackstoryCreation(playerName).EndLine());

        AnsiConsole.Markup(PlayerBuilderMessages.ListOriginOptions.EndLine());
        var origin = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select your origin: ")
                .AddChoices("Descendant", "Lawful", "Rich"));
        var tendencies = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select your trait: ")
                .AddChoices("Malignant", "Peaceful", "Just"));
        var priority = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select your priority: ")
                .AddChoices("Money", "People", "Expanse"));
        var ruler = RulerData.RulerDataBuilder(playerName, playerAge, origin, tendencies,priority);

        AnsiConsole.Markup("This is you: " + ruler);
    }
}