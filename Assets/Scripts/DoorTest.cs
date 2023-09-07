using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DoorTest : MonoBehaviour
{
    public bool open = true;
    public Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void Activate()
    {
        
        // if not playing an animation
        if (!animation.isPlaying)
        {
            // if close, open
            if (!open)
            {
                Debug.Log("Door Closing");
                animation.Play("door close");
                open = true;
            }

            // otherwise, if open, close
            else if (open)
            {
                Debug.Log("Door Opening");
                animation.Play("door open");
                open = false;
            }
        }
    }


}
