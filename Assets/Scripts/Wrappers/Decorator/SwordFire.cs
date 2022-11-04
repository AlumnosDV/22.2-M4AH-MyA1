using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFire : Sword
{
    public SwordFire(Sword decorator, int damage) : base(decorator, damage)
    {

    }

    protected override void OnTurnOn()
    {
        SwordFeedback.instance.FeedbackFire();
    }
}
