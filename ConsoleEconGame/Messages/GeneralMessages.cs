namespace ConsoleEconGame.Messages;

public class GeneralMessages
{
    public static string HelloMessage()
    {
        return
            @"Welcome to [underline violet]Callisto Empire[/], the newest and most advanced human colony in this part of the cluster. (...)";
    }

    public static string StartBackstoryCreation(string name)
    {
        return
            $@"Glad to have you here, {name}. In order to start governing your own colony, we need to establish what kind of ruler you're going to be. Please, consider your choices carefully.";
    }
}