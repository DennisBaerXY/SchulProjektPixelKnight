using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject ball;
    public GameObject spawnpunkt;
    public float spawnDelayTime;
    public float time;

    public float activeBalls;

    Vector3 positionSpawnpunkt;


    void Start()
    {
        activeBalls = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (activeBalls <= 30)
        {

        
            time = time + 1 * Time.deltaTime;
        
            if (time >= spawnDelayTime)
             {
              Instantiate(ball, spawnpunkt.transform);
              time = 0;

             activeBalls++;
              }
        }
    }
}
