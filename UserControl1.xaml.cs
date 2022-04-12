
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.UI.Xaml.Input;

namespace MemoryLeakTest;

public sealed partial class UserControl1
{

    private readonly byte[] buffer = new byte[int.MaxValue / 1000];

    private readonly List<SomeItem> _someData = new()
    {
        new SomeItem("Entry1",0),
        new SomeItem("Entry2",0),
        new SomeItem("Entry3",0),
        new SomeItem("Entry3",0),
    };

    public UserControl1()
    {
        this.InitializeComponent();
    }

    private void ThisEventCauseMemoryLeak(object sender, DoubleTappedRoutedEventArgs e)
    {

    }

    ~UserControl1()
    {
        Debug.WriteLine("Deconstructed");
    }

 
}