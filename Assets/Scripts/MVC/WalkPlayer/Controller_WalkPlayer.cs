using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_WalkPlayer : Controller
{
    float horiz;
    float vert;

    public float Horizontal => horiz;
    public float Vertical => vert;

    protected override void OnSetActive(bool val)
    {
       
    }

    protected override void OnTick(float DeltaTime)
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }

    protected override void OnTickFixed(float DeltaTime)
    {
        
    }
}
