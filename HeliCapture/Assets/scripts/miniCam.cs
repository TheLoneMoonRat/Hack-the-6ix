using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseMovement = Input.mousePosition;
        if (mouseMovement.x > 1664) {
            transform.Rotate(0, 0, -0.1f);
        } else if (mouseMovement.x < 896) {
            transform.Rotate(0, 0, 0.1f);
        }
    }
}
