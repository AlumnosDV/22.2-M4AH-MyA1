using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CarBase
{
    string name = "";
    public CarBase(string name)
    {
        this.name = name;
    }
    public virtual void TurnOn()
    {
        Debug.Log("Turn On " + name);
    }
}
