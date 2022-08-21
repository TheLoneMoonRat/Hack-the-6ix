using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectSpawn;
    public Transform objectSpawner;
    public officialScoreKeep othersa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            othersa.netAdding();
            Instantiate(objectSpawn, new Vector3((objectSpawner.position.x - 1), (objectSpawner.position.y - 7), objectSpawner.position.z), Quaternion.identity);
        }
    }
}
