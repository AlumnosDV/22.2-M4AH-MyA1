using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBuilder : MonoBehaviour
{
    void Start()
    {
        Sword toxic = new SwordToxic(null, 20);
        Sword ice = new SwordIce(null, 30);
        Sword fire = new SwordFire(null, 50);

        //Sword Memory;
        //for (int i = 0; i < length; i++)
        //{
        //    Sword swordBase = Sword(Memory,) ;
        //}
        


        Sword sword = new SwordFire(new SwordToxic(new SwordIce(null,12), 10), 20);

        sword.TurnOn();

        print(sword.GetDamage());
    }
}
