using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource MyFx;
    public AudioClip HoverFx;
    public AudioClip ClickFx;

    public void HoverSound()
    {
        MyFx.PlayOneShot(HoverFx);
    }
    public void ClickSound()
    {
        MyFx.PlayOneShot(ClickFx);
    }
}
