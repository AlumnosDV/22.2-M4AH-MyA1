using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MoveBase
{
    public MoveForward(Transform _transform) : base(_transform) { }
    public override void Do() => myTransform.position += Vector3.forward;
    public override void UnDo() => myTransform.position -= Vector3.forward;
}
