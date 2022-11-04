using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBuilder : MonoBehaviour
{
    private void Start()
    {
        Sword sword = new Sword_Fire(new Sword_Ice(new Sword_Toxic(null, 24), 73),50);
        sword.Execute();


        Debug.Log("El daño total es: " + sword.GetDamage());
    }
}
