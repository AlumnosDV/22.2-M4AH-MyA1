using UnityEngine;
public abstract class MoveBase : ICommand
{
    protected Transform myTransform;
    public MoveBase(Transform _transform)
    {
        myTransform = _transform;
    }
    public abstract void Do();
    public abstract void UnDo();
}
