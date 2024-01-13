﻿using System.Diagnostics;
using Lab4.Implementation;

namespace Lab4;

public class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        var hosts = new List<string>
        {
            "www.ubbcluj.ro",
            //"www.google.com",
            //"www.youtube.com",
           
        };
        
        Console.WriteLine("*******************************DIRECT CALLBACK**************************************");
        DirectCallback.Run(hosts);
        
        Console.WriteLine("***********************************TASKS********************************************");
        TaskMechanism.Run(hosts);
        
        
        Console.WriteLine("*******************************ASYNC/AWAIT TASKS************************************");
        AsyncTaskMechanism.Run(hosts);
    
    }
}