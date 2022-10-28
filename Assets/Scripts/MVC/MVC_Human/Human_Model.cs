using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Model : Model
{
    [SerializeField] Rigidbody myRig;
    [SerializeField] float walkspeed = 100;

    protected override void FixedUpdate(float DeltaTime)
    {
        base.FixedUpdate(DeltaTime);
        myRig.velocity = Move * walkspeed * Time.deltaTime;
    }
}
