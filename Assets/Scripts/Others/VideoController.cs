using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour, IPausable
{

    VideoPlayer myVideo;
    void Start()
    {
        myVideo = GetComponent<VideoPlayer>();
        SM.instance.AddPausable(this);
    }

    public void Play()
    {
        myVideo.Play();
    }
    public void Pause()
    {
        myVideo.Pause();
    }

    void IPausable.Pause()
    {
        myVideo.Pause();
    }

    void IPausable.Resume()
    {
        myVideo.Play();
    }
}
