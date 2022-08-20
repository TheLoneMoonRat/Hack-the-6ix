using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseMovement = Input.mousePosition;
        float forwardMotion = Input.GetAxisRaw("Vertical");
        float sideMotion = Input.GetAxisRaw("Horizontal");
        transform.Translate(sideMotion/90, forwardMotion/90, 0);
        Debug.Log(mouseMovement);
        if (mouseMovement.x > 1664) {
            transform.Rotate(0, 0, -0.1f);
        } else if (mouseMovement.x < 896) {
            transform.Rotate(0, 0, 0.1f);
        }
    }
}
