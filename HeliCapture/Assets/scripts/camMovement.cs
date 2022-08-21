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
        float sideMotion = Input.GetAxisRaw("Horizontal");
        float forwardMotion = Input.GetAxisRaw("Vertical");
        transform.Translate(sideMotion/90, forwardMotion/80 + 0.02f, 0);
        if (mouseMovement.x > 1664) {
            transform.Rotate(0, 0, -0.1f);
        } else if (mouseMovement.x < 896) {
            transform.Rotate(0, 0, 0.1f);
        }
    }
}
