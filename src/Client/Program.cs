#region Decorator Pattern
using Decorator;

var alertMessage = new AlertMessage("This is an alert message");
var decoratedMessage = new ErrorDecorator(
        alertMessage
    );

alertMessage.PrintMessage();
decoratedMessage.PrintMessage();

#endregion
