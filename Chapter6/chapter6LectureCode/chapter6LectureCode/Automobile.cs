using System;

/// <summary>
/// Summary description for Class1
/// </summary>
// Base class
public class Automobile
{
    

    public string Accelerate()
    {
        return "zoom!";
    }
    //if you make a method or property private, it will not work when you call TheMethod() in Prigram.cs
    private string InjectFuel()
    {
        return "fueling at pump";
    }

}

// Derived class
public class Car : Automobile { }




