using Cinemachine;
using UnityEngine;
[System.Serializable]

public abstract class View : MVCComponent
{
    [SerializeField] CinemachineVirtualCamera camera;
    protected Vector2 Move2D => move2d.normalized;
    Vector2 move2d = new Vector2(0, 0);
    protected Vector3 Move3D => move3d.normalized;
    Vector3 move3d = new Vector3(0, 0, 0);
    public void HorizontalInput(float val) { move2d.x = val; move3d.x = val; }
    public void VerticalInput(float val) { move2d.y = val; move3d.z = val; }

    bool highprofile = false;
    protected bool HighProfile => highprofile;
    public void HighProfileInput(bool val) { highprofile = val; }

    protected override void OnActive()
    {
        camera.Priority = 100;
    }
    protected override void OnDeactive()
    {
        camera.Priority = 0;
    }
}
