namespace Pattern.Behavioral.State;

public class Context
{
    private State? _state;

    public Context(State state)
    {
        TransitionTo(state);
    }

    public void TransitionTo(State state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}");
        _state = state;
        _state.SetContex(this);
    }

    public void DoThis()
    {
        _state?.Handle1();
    }

    public void DoThat()
    {
        _state?.Handle2();
    }
}
