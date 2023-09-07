using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public DoorTest door;

    Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void PushButton()
    {
        // if not playing an animation
        if (!animation.isPlaying)
        {
            Debug.Log("Animating");

            animation.Play("PushButton");

        }
    }
}
