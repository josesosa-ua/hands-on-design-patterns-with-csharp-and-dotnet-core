namespace Pattern.Structural.Component;

public class Leaf : Component
{
    public override string Operation()
    {
        return "I'm a leaf";
    }

    public override bool IsComposite()
    {
        return false;
    }
}
