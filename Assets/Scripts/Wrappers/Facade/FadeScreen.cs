using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScreen : MonoBehaviour
{
    public static FadeScreen instance;
    [SerializeField] CanvasGroup group;
    float speed = 1;

    float timer = 0;
    float time_to_fade = 1f;
    bool anim;
    bool enter;

    public void SetSpeed(float speed = 1f)
    {
        this.speed = speed;
    }
    public void SetAnimationTime(float time_to_fade = 1f)
    {
        this.time_to_fade = time_to_fade;
    }
    public void FadeIn()
    {
        anim = true;
        enter = true;
        timer = 0;
    }
    public void FadeOut()
    {
        anim = true;
        enter = false;
        timer = 0;
    }

    void Fade(float lerp)
    {
        group.alpha = enter ? lerp : (1 - lerp) ;
    }

    private void Update()
    {
        if (anim)
        {
            if (timer < time_to_fade)
            {
                timer = timer + speed * Time.deltaTime;
                Fade(timer / time_to_fade);
            }
            else
            {
                timer = 0;
                anim = false;
            }
        }
    }
}
