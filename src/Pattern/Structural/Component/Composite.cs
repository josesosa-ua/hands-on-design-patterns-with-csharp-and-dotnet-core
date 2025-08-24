using System.Text;

namespace Pattern.Structural.Component;

public class Composite : Component
{
    private readonly List<Component> _children = [];

    public override string Operation()
    {
        var result = new StringBuilder();
        result.Append("Branch(");
        foreach (var child in _children)
        {
            result.Append(child.Operation());
        }
        result.Append(')');
        return result.ToString();
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }
}
