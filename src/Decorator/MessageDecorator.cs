namespace Decorator;

public abstract class MessageDecorator : IMessage
{
    protected readonly Message _message; // Decorator implements the same interface as the component it decorates

    public MessageDecorator(Message message)
    {
        _message = message;
    }

    public abstract void PrintMessage();
}
