using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_PlayerWalk : View
{

    Animator anim;
    public void RefreshMovement(float velocitymagnitude)
    {
        if (!anim) return;
        anim.SetBool("Move", velocitymagnitude > 0.2f);
    }
}
