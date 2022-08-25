using MvvmGen;

namespace MemoryLeakTest;

[ViewModel]
public partial class SomeItem
{
    [Property] private string _value;
    [Property] private int _value2;
    [Property] private bool _value3 = true;
}