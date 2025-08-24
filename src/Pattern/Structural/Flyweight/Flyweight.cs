using Newtonsoft.Json;

namespace Pattern.Structural.Flyweight;

public class Flyweight
{
    private Vehicle _sharedState;

    public Flyweight(Vehicle car)
    {
        _sharedState = car;
    }

    public void Operation(Vehicle uniqueState)
    {
        var serializedSharedState = JsonConvert.SerializeObject(_sharedState);
        var serializedUniqueState = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying the shared {serializedSharedState} and unique {serializedUniqueState} sate of this object.");
    }
}
