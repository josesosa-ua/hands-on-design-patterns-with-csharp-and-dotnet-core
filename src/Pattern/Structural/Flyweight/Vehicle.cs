namespace Pattern.Structural.Flyweight;

public record class Vehicle
{
    public string Owner { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
}
