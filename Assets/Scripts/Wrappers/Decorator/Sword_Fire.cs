using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Fire : Sword
{
    public Sword_Fire(Sword sword, int damage = 20) : base(sword, damage)
    {
    }

    protected override void OnExecute()
    {
        Debug.Log("EJECUTANDO FUEGO");
    }
}
