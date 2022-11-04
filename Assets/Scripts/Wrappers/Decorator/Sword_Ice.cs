using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Ice : Sword
{
    public Sword_Ice(Sword sword, int damage = 20) : base(sword, damage)
    {
    }

    protected override void OnExecute()
    {
        Debug.Log("EJEcutando HIELO");
    }
}
