using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeActivater : MonoBehaviour
{
    public GameObject spikes;
    private MovingSpikes sp;

    void Start()
    {
        sp = spikes.GetComponent<MovingSpikes>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sp.activate = true;
    }
}
