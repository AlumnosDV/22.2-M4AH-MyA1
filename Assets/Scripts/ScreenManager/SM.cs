using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///    (screen manager)
public class SM : MonoBehaviour
{
    public static SM instance;
    private void Awake()
    {
        instance = this;
    }

    HashSet<IPausable> pausables = new HashSet<IPausable>();

    public void AddPausable(IPausable pausable) => pausables.Add(pausable);
    public void RemovePausable(IPausable pausable) => pausables.Remove(pausable);



    public void Pause()
    {
        foreach (var item in pausables)
        {
            item.Pause();
        }
    }

    public void Resume()
    {
        foreach (var item in pausables)
        {
            item.Resume();
        }
    }
}
