namespace Pattern.ChainOfResponsibility;

public abstract class ServiceHandler
{
    protected ServiceHandler? _nextServiceHandler;
    protected Services _servicesProvided;

    public ServiceHandler(Services servicesProvided)
    {
        _servicesProvided = servicesProvided;
    }

    public void Service(Car car)
    {
        ArgumentNullException.ThrowIfNull(car);

        if (CanProvideAllRequiredServices(car))
        {
            PerformServices(car);
        }
        if (IsServiceCompletedOrNoMoreProviders(car))
        {
            return;
        }
        else
        {
            _nextServiceHandler?.Service(car);
        }
    }

    private bool CanProvideAllRequiredServices(Car car)
    {
        var serviceProvider = GetType().Name;
        Console.WriteLine($"{serviceProvider} is providing {_servicesProvided} services.");
        return _servicesProvided == (car.ServicesRequired & _servicesProvided);
    }

    private void PerformServices(Car car)
    {
        car.ServicesRequired &= ~_servicesProvided;
    }

    private bool IsServiceCompletedOrNoMoreProviders(Car car)
    {
        return car.IsServiceComplete() || _nextServiceHandler == null;
    }

    public ServiceHandler SetNextServiceHandler(ServiceHandler nextServiceHandler)
    {
        _nextServiceHandler = nextServiceHandler;
        return nextServiceHandler;
    }
}
