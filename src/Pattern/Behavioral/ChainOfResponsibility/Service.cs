namespace Pattern.ChainOfResponsibility;

[Flags]
public enum Services
{
    None = 0,
    WheelAlignment = 1 << 0,
    Dirty = 1 << 1,
    EngineTuneup = 1 << 2,
    TestDrive = 1 << 3,
}
