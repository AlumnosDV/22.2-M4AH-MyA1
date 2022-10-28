using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Human_Model : Model
{
    [SerializeField] Rigidbody myRig;
    float movementspeed = 200;
    [SerializeField] float walkspeed = 200;
    [SerializeField] float runspeed = 400;

    [SerializeField] Transform root;
    [SerializeField] float root_lookspeed = 20f;

    protected override void OnActive()
    {
        Debug.Log("Se activa model del human");
    }
    protected override void OnDeactive()
    {
        Debug.Log("Se desactiva model del human");
    }

    public override void HighProfileInput(bool val)
    {
        base.HighProfileInput(val);
        if (val)
        {
            movementspeed = runspeed;
        }
        else
        {
            movementspeed = walkspeed;
        }

    }
    protected override void Update(float DeltaTime)
    {
        root.forward = Vector3.Slerp(root.forward, Move, root_lookspeed * Time.deltaTime);
    }


    protected override void FixedUpdate(float DeltaTime)
    {
        myRig.velocity = Move * movementspeed * DeltaTime;
    }
}
