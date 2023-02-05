// See https://aka.ms/new-console-template for more information

using ConsoleEconGame;
using ConsoleEconGame.Enums;
using ConsoleEconGame.Messages;
using Spectre.Console;

AnsiConsole.Write(
    new FigletText("Callisto Empire").Color(Color.Violet));

AnsiConsole.Markup(GeneralMessages.HelloMessage().EndLine());

/*
 * TODO: Add length validation for player name.
 */
var playerName = AnsiConsole.Ask<string>(PlayerBuilderMessages.AskForName());
var playerAge = AnsiConsole.Prompt(new TextPrompt<int>(PlayerBuilderMessages.AskForAge())
    .PromptStyle("red").ValidationErrorMessage("[red]This is not a valid age.")
    .Validate(age =>
    {
        return age switch
        {
            <= 0 => ValidationResult.Error(ValidationErrors.AgeTooLowError()),
            >= 99 => ValidationResult.Error(ValidationErrors.AgeTooHighError()),
            _ => ValidationResult.Success()
        };
    }));
AnsiConsole.Markup(GeneralMessages.StartBackstoryCreation(playerName).EndLine());


var ruler = RulerData.RulerDataBuilder(playerName, playerAge, "", "", "");


