using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalMovement : MonoBehaviour
{
    // Start is called before the first frame update
        int phaseTrack = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Path());
    }
    IEnumerator Path()
    {
      if (phaseTrack <= 2000) 
      {
        yield return new WaitForSeconds(0.01f);
        transform.Translate(0.01f, 0, 0);
      } else if (phaseTrack <= (4000)) {
        yield return new WaitForSeconds(0.01f);
        transform.Translate(0, 0, 0.01f);
      } else if (phaseTrack <= (6000)) {
        yield return new WaitForSeconds(0.01f);
        transform.Translate(-0.01f, 0, 0);
      } else if (phaseTrack <= 8000) {
        yield return new WaitForSeconds(0.01f);
        transform.Translate(0, 0, -0.01f);
      } else {
        phaseTrack = 0;
      }
      phaseTrack += 1;
    }
}
