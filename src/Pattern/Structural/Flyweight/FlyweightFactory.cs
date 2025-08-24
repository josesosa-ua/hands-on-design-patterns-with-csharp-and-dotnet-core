namespace Pattern.Structural.Flyweight;

public class FlyweightFactory
{
    private List<Tuple<Flyweight, string>> _flyweights = [];

    public FlyweightFactory(params Vehicle[] cars)
    {
        foreach (var car in cars)
        {
            _flyweights.Add(Tuple.Create(new Flyweight(car), GetKey(car)));
        }
    }

    public static string GetKey(Vehicle car)
    {
        List<string> carProperties = [];
        carProperties.Add(car.Model);
        carProperties.Add(car.Color);
        carProperties.Add(car.Company);

        if ((car.Owner is not null) && (car.Number is not null))
        {
            carProperties.Add(car.Owner);
            carProperties.Add(car.Number);
        }
        carProperties.Sort();

        return string.Join("_", carProperties);
    }

    public Flyweight GetFlyweight(Vehicle sharedState)
    {
        string key = GetKey(sharedState);

        if (!_flyweights.Any(t => t.Item2 == key))
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }
        var tuple = _flyweights.FirstOrDefault(t => t.Item2 == key) ?? throw new InvalidOperationException($"No flyweight found for key: {key}");
        return tuple.Item1;
    }

    public void ListFlyweights()
    {
        var count = _flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in _flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}
