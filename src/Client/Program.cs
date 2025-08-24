using Pattern.ChainOfResponsibility;
using Pattern.Decorator;
using Pattern.Structural.Component;
using Pattern.Structural.Flyweight;

#region Decorator Pattern

var alertMessage = new AlertMessage("This is an alert message");
var decoratedMessage = new ErrorDecorator(
        alertMessage
    );

alertMessage.PrintMessage();
decoratedMessage.PrintMessage();

#endregion

//-----------------------------------------------------------------

#region Chain of Responsibility

var mechanic = new Mechanic();
var wheelSpecialist = new WheelSpecialist();
var detailer = new Detailer();
var qualityControl = new QualityControl();

mechanic.SetNextServiceHandler(wheelSpecialist)
    .SetNextServiceHandler(detailer)
    .SetNextServiceHandler(qualityControl);

var vwBeetle = new Car(Services.EngineTuneup | Services.WheelAlignment | Services.Dirty | Services.TestDrive);
var fordFocus = new Car(Services.WheelAlignment | Services.Dirty | Services.TestDrive);

mechanic.Service(vwBeetle);
detailer.Service(fordFocus);

#endregion

//-----------------------------------------------------------------

#region Composite

var tree = new Composite();
var branch1_1 = new Composite();
var branch1_2 = new Composite();
var branch2 = new Composite();
var leaf = new Leaf();

branch1_2.Add(branch2);
branch2.Add(leaf);
tree.Add(branch1_1);
tree.Add(branch1_2);

Console.WriteLine(tree.Operation());

#endregion

//-----------------------------------------------------------------

#region Flyweight

// The client code usually creates a bunch of pre-populated
// flyweights in the initialization stage of the application.
var factory = new FlyweightFactory(
    new Vehicle { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
    new Vehicle { Company = "Mercedes Benz", Model = "C300", Color = "black" },
    new Vehicle { Company = "Mercedes Benz", Model = "C500", Color = "red" },
    new Vehicle { Company = "BMW", Model = "M5", Color = "red" },
    new Vehicle { Company = "BMW", Model = "X6", Color = "white" }
);
factory.ListFlyweights();

addCarToPoliceDatabase(factory, new Vehicle
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "M5",
    Color = "red"
});

addCarToPoliceDatabase(factory, new Vehicle
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "X1",
    Color = "red"
});

factory.ListFlyweights();

static void addCarToPoliceDatabase(FlyweightFactory factory, Vehicle car)
{
    Console.WriteLine("\nClient: Adding a car to database.");

    var flyweight = factory.GetFlyweight(new Vehicle
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyweight.Operation(car);
}

#endregion