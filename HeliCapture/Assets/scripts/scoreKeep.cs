using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeep : MonoBehaviour
{
    public int highScore;
    // Start is called before the first frame update
    void OnCollisionEnter (Collision collisionInfo) {
        var words = collisionInfo.collider.name.Substring(0, 2);
        Debug.Log(words);
        Debug.Log(collisionInfo.collider.name);
        if (words == "Ba") {
            highScore += 2;
        } else if (words == "Bi") {
            highScore += 1;
        } else if (words == "Fa") {
            highScore += 3;
        } else if (words == "Ev") {
            highScore += 5;
        } else {
            Debug.Log("It's not working :(");
        }
    }
}
