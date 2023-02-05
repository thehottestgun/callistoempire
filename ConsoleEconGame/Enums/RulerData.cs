namespace ConsoleEconGame.Enums;

[Serializable]
public class RulerData
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Origin { get; set; }
    public string Tendencies { get; set; }
    public string Priority { get; set; }

    public static RulerData RulerDataBuilder(string name, int age, string origin, string tendencies, string priority)
    {
        return new RulerData
        {
            Name = name,
            Age = age,
            Origin = origin,
            Tendencies = tendencies,
            Priority = priority
        };
    }
}