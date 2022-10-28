using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_ViewSpecial : View
{
    protected override void OnActive()
    {
        Debug.Log("Se activo el Especial");
    }

    protected override void OnDeactive()
    {
        Debug.Log("Se desactivo el Especial");
    }

    protected override void Update(float DeltaTime)
    {
        Debug.Log("el Especial Updatea");
    }

    protected override void FixedUpdate(float DeltaTime)
    {
        Debug.Log("el Especial FixedUpdatea");
    }


}
