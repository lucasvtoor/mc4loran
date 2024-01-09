namespace Settings;

public abstract class Setting<T>(string value, string name)
{
    public readonly T Value = (T)Convert.ChangeType(value, typeof(T));
    public string Name = name;
}