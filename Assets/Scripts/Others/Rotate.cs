using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float XspeedRotation = 1;
    public float YspeedRotation = 1;
    public float ZspeedRotation = 1;
    bool isPlaying = false;
    public float beginOnTime = 3;
    private void Start()
    {
        Invoke("Play", beginOnTime);
    }
    public void Play() => isPlaying = true;
    public void Pause() => isPlaying = false;
    void Update()
    {
        if (!isPlaying) return;

        transform.Rotate(XspeedRotation * Time.deltaTime, YspeedRotation * Time.deltaTime, ZspeedRotation * Time.deltaTime);
    }
}
