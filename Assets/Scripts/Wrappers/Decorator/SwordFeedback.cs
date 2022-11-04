using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFeedback : MonoBehaviour
{
    public static SwordFeedback instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] ParticleSystem ice;
    [SerializeField] ParticleSystem fire;
    [SerializeField] ParticleSystem toxic;
    public void FeedbackFire()
    {
        fire.Play();
    }
    public void FeedbackToxic()
    {
        toxic.Play();
    }
    public void FeedbackIce ()
    {
        ice.Play();
    }
}
