using System;
using System.Diagnostics;

namespace SortManager;

public class Timer
{
    public Stopwatch timer = new();
    public void Start()
    {
        //Stopwatch methodTimer = new Stopwatch();
        timer.Start();
    }

    public string Stop()
    {
        timer.Stop();
        return(timer.Elapsed.ToString(@"mm\:ss\:ffffff"));
    }

}

