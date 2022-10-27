using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MVCComponent : MonoBehaviour
{
    bool isActive;
    public void SetActive(bool val)
    {
        isActive = val;
        OnSetActive(val);
    }

    protected abstract void OnSetActive(bool val);

    private void Update()
    {
        if (isActive)
        {
            OnTick(Time.deltaTime);
        }
    }
    protected abstract void OnTick(float DeltaTime);

    private void FixedUpdate()
    {
        if (isActive)
        {
            OnTickFixed(Time.deltaTime);
        }
    }
    protected abstract void OnTickFixed(float DeltaTime);
}
