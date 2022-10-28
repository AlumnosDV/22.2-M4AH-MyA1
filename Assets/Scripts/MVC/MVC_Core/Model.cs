using UnityEngine;
[System.Serializable]
public abstract class Model : MVCComponent
{
    protected Vector3 Move => move.normalized;
    Vector3 move = new Vector3(0, 0, 0);

    public void HorizontalInput(float val) { move.x = val; }
    public void VerticalInput(float val) { move.z = val; }

    bool highprofile = false;
    protected bool HighProfile => highprofile;
    public virtual void HighProfileInput(bool val) { highprofile = val; }
}
