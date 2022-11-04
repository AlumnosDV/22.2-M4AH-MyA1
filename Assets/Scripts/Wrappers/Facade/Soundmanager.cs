using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClienteFacade
{
    void Start()
    {
        //se va a reproducir la silla especial
        Soundmanager.instance.PlaySound("Silla", false, 0.75f, Soundmanager.priority.high, new Vector3(500, 24, 15), true);

        Soundmanager.instance.PlaySillaEspecial();

        Soundmanager.PlaySilla();
    
    }
}

public class Soundmanager : MonoBehaviour
{
    public static Soundmanager instance;
    private void Awake()
    {
        instance = this;
    }

    public enum priority
    {
        low, mediumn, high
    }

    public static void PlaySilla()
    {
        instance.PlaySillaEspecial();
    }

    public void PlaySillaEspecial()
    { 
        PlaySound("Silla", false, 0.75f, Soundmanager.priority.high, new Vector3(500, 24, 15), true); 
    }


    public void PlaySound(string key, bool loop, float volume, priority prority, Vector3 pos, bool track = false)
    {
        //zaraza
    }
}
