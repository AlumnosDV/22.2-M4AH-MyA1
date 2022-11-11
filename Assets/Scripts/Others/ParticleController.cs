using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour, IPausable
{
    ParticleSystem particleSystem;

    public float beginOnTime = 3;
    private void Start()
    {
        Invoke("Play", beginOnTime);
        particleSystem = GetComponent<ParticleSystem>();
        SM.instance.AddPausable(this);
    }

    public void Play()
    {
        particleSystem.Play();
    }
    public void Pause()
    {
        particleSystem.Pause();
    }

    void IPausable.Pause()
    {
        particleSystem.Pause();
    }

    void IPausable.Resume()
    {
        particleSystem.Play();
    }
}
