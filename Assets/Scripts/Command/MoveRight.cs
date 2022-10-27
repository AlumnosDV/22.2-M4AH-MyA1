using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MoveBase
{
    public MoveRight(Transform _transform) : base(_transform) { }
    public override void Do() => myTransform.position += Vector3.right;
    public override void UnDo() => myTransform.position -= Vector3.right;
}
