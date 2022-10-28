using UnityEngine;

[System.Serializable]
public class Human_View : View
{
    [SerializeField] Animator anim;

    protected override void Update(float DeltaTime)
    {
        if (!anim) return;
        anim.SetFloat("movespeed", Move3D.normalized.magnitude * (HighProfile ? 1 :0.5f));
    }
}
