namespace ServicesCmp.Services;
public class MyService : IDisposable
{
    private string component;
    public MyService()
    {
        Console.WriteLine("MyService created");
    }

    public string GetData() => "Data";
    public string SetComponent(string cmp) => component = cmp;

    public void Dispose()
    {
        Console.WriteLine("MyService disposed. Component : " + component);
    }
}
