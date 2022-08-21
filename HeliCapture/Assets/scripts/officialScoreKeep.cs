using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class officialScoreKeep : MonoBehaviour
{
    public int highScore = 0;
    public Text scoreText;
    public int nets = 0;
    public int timer = 0; 
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

    public void netAdding () {
        nets += 1;
    }

    void Start () {
        StartCoroutine(Timer());
    }
    void Update () {
        scoreText.text = "Current score: " + highScore + "\nNets used:" + nets + "\nTime remaining:" + (100 - timer); 
    }

    IEnumerator Timer() {
        while (timer < 100) {
            yield return new WaitForSeconds(1f);
            timer =  timer + 1;
        }
    }
}
