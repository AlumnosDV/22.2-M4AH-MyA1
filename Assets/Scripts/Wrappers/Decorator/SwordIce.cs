using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordIce : Sword
{
    public SwordIce(Sword decorator, int damage) : base(decorator, damage)
    {
    }

    protected override void OnTurnOn()
    {
        SwordFeedback.instance.FeedbackIce();
    }
}
