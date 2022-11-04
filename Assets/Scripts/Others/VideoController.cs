using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    VideoPlayer myVideo;
    void Start()
    {
        myVideo = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        myVideo.Play();
    }
    public void Pause()
    {
        myVideo.Pause();
    }
}
