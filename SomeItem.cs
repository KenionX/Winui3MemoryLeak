namespace MemoryLeakTest;

public class SomeItem
{
    public string Value { get; set; }
    public int Value2 { get; set; }

    public SomeItem(string value, int value2)
    {
        Value = value;
        Value2 = value2;
    }
}