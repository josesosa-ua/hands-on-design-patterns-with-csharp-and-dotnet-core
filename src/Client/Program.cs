using ChainOfResponsibility;
using Decorator;

#region Decorator Pattern
var alertMessage = new AlertMessage("This is an alert message");
var decoratedMessage = new ErrorDecorator(
        alertMessage
    );

alertMessage.PrintMessage();
decoratedMessage.PrintMessage();

#endregion

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