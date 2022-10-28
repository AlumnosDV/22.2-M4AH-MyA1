using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_View : View
{

    Animator anim;
    public void RefreshMovement(float velocitymagnitude)
    {
        if (!anim) return;
        anim.SetBool("Move", velocitymagnitude > 0.2f);
    }
}
