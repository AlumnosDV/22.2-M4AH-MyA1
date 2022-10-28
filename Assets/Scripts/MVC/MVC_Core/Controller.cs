using UnityEngine;
using System;
[System.Serializable]
public abstract class Controller : MVCComponent
{

    public event Action<float> Horizontal = delegate { };
    public event Action<float> Vertical = delegate { };
    public event Action<bool> HighProfile = delegate { };
    protected override void Update(float DeltaTime)
    {
        base.Update(DeltaTime);
        Horizontal.Invoke(Input.GetAxis("Horizontal"));
        Vertical.Invoke(Input.GetAxis("Vertical"));
        if (Input.GetButtonDown("Run")) HighProfile.Invoke(true);
        else if (Input.GetButtonUp("Run")) HighProfile.Invoke(false);
    }
}
