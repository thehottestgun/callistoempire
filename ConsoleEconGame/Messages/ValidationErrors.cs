namespace ConsoleEconGame.Messages;

public class ValidationErrors
{
    public static string AgeTooLowError()
    {
        return @"[red]You're too young to rule over Callisto.";
    }

    public static string AgeTooHighError()
    {
        return @"[red]A ruler this old cannot govern Callisto.";
    }
}