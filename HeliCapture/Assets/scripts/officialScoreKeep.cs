using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officialScoreKeep : MonoBehaviour
{
    public int highScore = 0;
    // Start is called before the first frame update
    public void Scoreadding (string tier) 
    {
        if (tier == "Ba") {
            highScore += 2;
        } else if (tier == "Bi") {
            highScore += 1;
        } else if (tier == "Fa") {
            highScore += 3;
        } else if (tier == "Ev") {
            highScore += 5;
        }
    }
}
