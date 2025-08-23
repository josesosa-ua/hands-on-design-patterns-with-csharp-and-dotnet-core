namespace ChainOfResponsibility;

public class Detailer : ServiceHandler
{
    public Detailer() : base(Services.Dirty) { }

}
