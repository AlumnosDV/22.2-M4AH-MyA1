using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordToxic : Sword
{
    public SwordToxic(Sword decorator, int damage) : base(decorator, damage)
    {

    }

    protected override void OnTurnOn()
    {
        SwordFeedback.instance.FeedbackToxic();
    }
}
