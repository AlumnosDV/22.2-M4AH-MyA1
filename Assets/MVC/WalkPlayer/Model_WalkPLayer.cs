using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_WalkPLayer : Model
{
    Rigidbody myRig;

    [SerializeField] float walkspeed = 100;
    Vector3 move = new Vector3(0, 0, 0);

    private void Start()
    {
        myRig = GetComponent<Rigidbody>();
    }

    protected override void OnSetActive(bool val)
    {

    }

    public void VerticalMove(float val)
    {
        move.z = val;
    }
    public void HorizontalMove(float val)
    {
        move.x = val;
    }

    protected override void OnTick(float DeltaTime)
    {
        
    }

    protected override void OnTickFixed(float DeltaTime)
    {
        myRig.velocity = move.normalized * walkspeed * Time.deltaTime;
    }
}
