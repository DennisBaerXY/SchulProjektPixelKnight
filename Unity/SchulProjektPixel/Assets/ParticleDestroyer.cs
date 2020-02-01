using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    public float lifetime;
    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
}
