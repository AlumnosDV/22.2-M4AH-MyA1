using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CarBase gasoil = new CarGasOil("Gasoil");
        CarBase Electric = new CarElectric("Electrics");
        CarBase Steam = new CarSteamAdapter("Steam");

        List<CarBase> cars = new List<CarBase>();
        cars.Add(gasoil);
        cars.Add(Electric);
        cars.Add(Steam);

        foreach (var car in cars)
        {
            car.TurnOn();
        }
    }

}
