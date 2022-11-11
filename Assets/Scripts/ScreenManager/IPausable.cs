using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActivableObject
{
    void Activate();
    void Deactivate();
}

public interface IPausable
{
    void Pause();
    void Resume();
}

public interface ITickeable
{
    void Tick(float deltaTime);
}
public interface IFixedTickeable
{
    void Tick(float deltaTime);
}
