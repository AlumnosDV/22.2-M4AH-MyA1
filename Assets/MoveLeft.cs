using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MoveBase
{
    public MoveLeft(Transform _transform) : base(_transform) { }
    public override void Do() => myTransform.position += Vector3.left;
    public override void UnDo() => myTransform.position -= Vector3.left;
}
