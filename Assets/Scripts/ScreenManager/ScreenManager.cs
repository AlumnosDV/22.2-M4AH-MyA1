using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScreenManager : MonoBehaviour
{
    public UnityEvent Pause;
    public UnityEvent play;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            play.Invoke();
        }
    }
}
