using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    public GameObject triggerObject;

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Player")
        {

            if (triggerObject.GetComponent<DoorTest>().open == false)
                triggerObject.GetComponent<DoorTest>().Activate();

        }
    }

    private void OnTriggerExit(Collider collider)
    {

        if (collider.tag == "Player")
        {

            if (triggerObject.GetComponent<DoorTest>().open == true) // && triggerObject.GetComponent<DoorTest>().animation.isPlaying == false)
                triggerObject.GetComponent<DoorTest>().Activate();

        }
    }

}
