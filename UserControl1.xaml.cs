
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.WinUI.UI.Controls;
using Microsoft.UI.Xaml.Controls;

namespace MemoryLeakTest;

public sealed partial class UserControl1
{
    public static int DeconstructCounter = 0;
    private readonly byte[] _buffer = new byte[int.MaxValue / 1000];

    private readonly ObservableCollection<SomeItem> _someData = new()
    {
        new SomeItem{Value = "Entry1", Value2 = 0},
        new SomeItem{Value = "Entry2", Value2 = 1},
        new SomeItem{Value = "Entry3", Value2 = 2},
        new SomeItem{Value = "Entry4", Value2 = 3},
        new SomeItem{Value = "Entry5", Value2 = 4},
        new SomeItem{Value = "Entry6", Value2 = 5},
        new SomeItem{Value = "Entry7", Value2 = 6},
    };

    public UserControl1()
    {
        this.InitializeComponent();
    }

    ~UserControl1()
    {
        Debug.WriteLine("Deconstructed");
        DeconstructCounter++;
    }


    private void ItemListDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is not DataGrid dGrid)
            return;
        dGrid.SelectedIndex = -1;
    }
}