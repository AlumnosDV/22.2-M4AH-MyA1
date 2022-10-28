using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car_Model : Model
{
    public float speed = 5;
    float aceleration = 0;
    public Transform root;
    public float rotationSpeed = 10f;
    
    protected override void OnActive()
    {
       
    }
    protected override void OnDeactive()
    {
        
    }

    protected override void FixedUpdate(float DeltaTime)
    {
        if (Move.z > 0.1f)
        {
            aceleration += DeltaTime;
        }
        else if (Move.z < -0.1f)
        {
            aceleration -= DeltaTime;
        }
        if (aceleration > 2)
        {
            aceleration = 2;
        }
        if (aceleration < -2)
        {
            aceleration = -2;
        }

        Vector3 dir = root.transform.forward;

        if(Mathf.Abs(aceleration) > 0.1f)
        {
            if (Move.x > 0.1f)
            {
                root.transform.forward = Vector3.Slerp(root.transform.forward, root.transform.right, DeltaTime * rotationSpeed);
            }
            else if (Move.x < -0.1f)
            {
                root.transform.forward = Vector3.Slerp(root.transform.forward, root.transform.right * -1, DeltaTime * rotationSpeed);
            }
        }

        root.transform.position = root.transform.position + root.transform.forward * aceleration * speed * DeltaTime;

    }
}
