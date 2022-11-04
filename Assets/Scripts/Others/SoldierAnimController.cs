using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimController : MonoBehaviour
{
    Animator animator;

    public float beginDance = 2f;
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("Dance", beginDance);
    }

    public void Dance()
    {
        animator.SetTrigger("Dance");
    }

    public void Play()
    {
        animator.speed = 1;
    }
    public void Pause()
    {
        animator.speed = 0;
    }
}
