using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem particleSystem;

    public float beginOnTime = 3;
    private void Start()
    {
        Invoke("Play", beginOnTime);
        particleSystem = GetComponent<ParticleSystem>();
    }

    public void Play()
    {
        particleSystem.Play();
    }
    public void Pause()
    {
        particleSystem.Pause();
    }

    
}
