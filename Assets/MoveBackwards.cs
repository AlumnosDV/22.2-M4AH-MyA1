using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MoveBase
{
    public MoveBackwards(Transform _transform) : base(_transform) { }
    public override void Do() => myTransform.position += Vector3.back;
    public override void UnDo() => myTransform.position -= Vector3.back;
}
