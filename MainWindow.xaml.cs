using System;
using System.Diagnostics;
using System.Threading;

namespace MemoryLeakTest;

public sealed partial class MainWindow
{
    private int _currentInstance = 0;

    public MainWindow()
    {
        this.InitializeComponent();
        new Thread(() =>
        {
            while (true)
            {
                DispatcherQueue.TryEnqueue(SpawnInstance);

                if(_currentInstance % 10 == 0)
                    GC.Collect();

                Thread.Sleep(100);
            }
        }).Start();
    }

    private void SpawnInstance()
    {
        SomeFrame.Content = new UserControl1();
        _currentInstance++;
        Debug.WriteLine($"Current Instances: {_currentInstance}");
    }
}