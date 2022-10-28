using UnityEngine;
[System.Serializable]
public abstract class Model : MVCComponent
{
    protected Vector2 Move => move.normalized;
    Vector2 move = new Vector2(0, 0);
    public void HorizontalInput(float val) => move.x = val;
    public void VerticalInput(float val) => move.x = val;
}
