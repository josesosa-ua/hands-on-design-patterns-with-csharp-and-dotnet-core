namespace Pattern.Behavioral.State;

public abstract class State
{
    protected Context _context;

    public void SetContex(Context context)
    {
        _context = context;
    }

    public abstract void Handle1();
    public abstract void Handle2();
}
