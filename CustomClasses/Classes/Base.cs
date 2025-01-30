namespace CustomClasses.Classes;

public class Base(string name)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; } = name;
    public DateTime CreateDateTime { get; } = DateTime.Now;
}
