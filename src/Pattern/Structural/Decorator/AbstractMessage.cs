namespace Pattern.Decorator;

/**
 * The abstract class is used to hold the message text for all message types.
 */
public abstract class Message : IMessage
{
    protected readonly string _text;

    public Message(string text)
    {
        _text = text;
    }

    public abstract void PrintMessage();
}

