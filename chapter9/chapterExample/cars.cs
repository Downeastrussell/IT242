// Base class
using System;
using System.Collections.Generic;

public class Automobile
{

    public string Accelerate()
    {
        return "zoom!";
    }

    private string InjectFuel()
    {
        return "fueling";
    }


}



// Derived class
public class Car : Automobile { }
public class Truck : Automobile { }