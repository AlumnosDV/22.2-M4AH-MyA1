using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_FEO : MonoBehaviour
{
    Rigidbody myRig;
    Animator anim;

    float horizontal;
    float vertical;

    float currentSpeed = 100;
    [SerializeField] float walkspeed = 100;
    [SerializeField] float runspeed = 100;
    Vector3 move = new Vector3(0, 0, 0);
    float yMove;

    [SerializeField] Transform pivot_root;
    [SerializeField] float root_lookspeed = 2f;
    float Thresholds = 0.5f;

    private void Awake()
    {
        myRig = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();

        currentSpeed = walkspeed;
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        move.x = horizontal;
        move.z = vertical;


        RefreshAnimator();

        pivot_root.forward = Vector3.Slerp(pivot_root.forward, move, root_lookspeed * Time.deltaTime);


        if (Input.GetButtonDown("Run"))
        {
            currentSpeed = runspeed;
            Thresholds = 1;
        }

        if (Input.GetButtonUp("Run"))
        {
            currentSpeed = walkspeed;
            Thresholds = 0.5f;
        }
    }

    private void FixedUpdate()
    {
        yMove = myRig.velocity.y;
        myRig.velocity = move.normalized * currentSpeed * Time.deltaTime;
        myRig.velocity = new Vector3(myRig.velocity.x, yMove, myRig.velocity.z);
    }

    void RefreshAnimator()
    {
        if (!anim) return;
        anim.SetFloat("movespeed", myRig.velocity.normalized.magnitude * Thresholds);
    }
}
