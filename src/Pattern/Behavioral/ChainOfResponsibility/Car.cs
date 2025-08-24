namespace Pattern.ChainOfResponsibility;

public class Car
{
    public Services ServicesRequired { get; set; }

    public Car(Services servicesRequired)
    {
        ServicesRequired = servicesRequired;
    }

    public bool IsServiceComplete()
    {
        return ServicesRequired == Services.None;
    }
}
