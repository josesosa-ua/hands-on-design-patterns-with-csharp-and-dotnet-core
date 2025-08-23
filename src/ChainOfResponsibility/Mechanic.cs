namespace ChainOfResponsibility;

public class Mechanic : ServiceHandler
{
    public Mechanic() : base(Services.EngineTuneup) { }

}
