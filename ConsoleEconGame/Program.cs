// See https://aka.ms/new-console-template for more information

using ConsoleEconGame;
using ConsoleEconGame.Confirmations;
using ConsoleEconGame.Flows;
using ConsoleEconGame.Messages;
using Spectre.Console;

AnsiConsole.Write(
    new FigletText("Callisto Empire").Color(Color.Violet));

AnsiConsole.Markup(GeneralMessages.HelloMessage.EndLine());

do
{
    GameStartFlow.ExecuteGameStartFlow();
} while(!Confirmations.AcceptPersonaConfirmation());