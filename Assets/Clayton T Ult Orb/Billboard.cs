using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public bool flip = false;

    private Vector3 scale;
    private void Start()
    {
        scale = transform.localScale;
    }

    void Update()
    {
        

        transform.LookAt(Camera.main.transform.position, Vector3.up);
        if (flip) { transform.localScale = new Vector3(scale.x * -1, scale.y, scale.z); }
    }
}
