using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimController : MonoBehaviour, IPausable
{
    Animator animator;

    public float beginDance = 2f;
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("Dance", beginDance);

        SM.instance.AddPausable(this);
    }

    public void Dance()
    {
        animator.SetTrigger("Dance");
    }

    //public void Play()
    //{
    //    animator.speed = 1;
    //}
    //public void Pause()
    //{
    //    animator.speed = 0;
    //}

    void IPausable.Pause()
    {
        animator.speed = 0;
    }

    void IPausable.Resume()
    {
        animator.speed = 1;
    }
}
