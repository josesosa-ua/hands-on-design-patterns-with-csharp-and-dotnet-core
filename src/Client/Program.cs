using Pattern.ChainOfResponsibility;
using Pattern.Decorator;
using Pattern.Structural.Component;

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
