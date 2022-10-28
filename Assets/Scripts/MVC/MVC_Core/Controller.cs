using UnityEngine;
public abstract class Controller : MVCComponent
{
    float horizontal = 0;
    float vertical = 0;
    public float Horizontal => horizontal;
    public float Vertical => vertical;
    protected override void Update(float DeltaTime)
    {
        base.Update(DeltaTime);
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
