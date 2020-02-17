using System;
using System.Collections.Generic;


public class Writer
{
    public Writer(string prefix) {
        Prefix = prefix;
    }

    public string Prefix {get; set;}

    public void Write (string message)
    {
        Console.WriteLine(Prefix + message);
    }
}

