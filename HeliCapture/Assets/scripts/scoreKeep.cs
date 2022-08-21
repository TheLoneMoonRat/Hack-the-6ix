using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeep : MonoBehaviour
{
    public officialScoreKeep other;

    // Start is called before the first frame update
    void OnCollisionEnter (Collision collisionInfo) {
        var words = collisionInfo.collider.name.Substring(0, 2);
        other.Scoreadding(words);
    }
}
