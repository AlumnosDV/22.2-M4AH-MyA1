using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteamAdapter : CarBase
{
    CarSteam myCar;

    public CarSteamAdapter(string name) : base(name)
    {
        myCar = new CarSteam();
    }

    public override void TurnOn()
    {
        base.TurnOn();

        myCar.ThrowCoal();
        myCar.PushLever();
        myCar.StartEngine();
    }
}
