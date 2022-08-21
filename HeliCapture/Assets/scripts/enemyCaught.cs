using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCaught : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.name == "Net(Clone)") {
            Destroy(gameObject);
        }
    } 
}
