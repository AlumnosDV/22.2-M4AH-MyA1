using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Toxic : Sword
{
    public Sword_Toxic(Sword sword, int damage = 20) : base(sword, damage)
    {
    }

    protected override void OnExecute()
    {
        Debug.Log("Ejecutando ToXIC");
    }

}
