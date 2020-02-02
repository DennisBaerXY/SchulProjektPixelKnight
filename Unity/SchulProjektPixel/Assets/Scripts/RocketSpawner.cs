using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    public GameObject Rocket;
    RaycastHit2D hit;

    public float distance;
    public float Spawntime;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
       
        time = Spawntime;
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(transform.position, Vector2.left, distance);
        if (hit.collider.tag == "Player")
        {
            print("Hit");
            time += time * Time.deltaTime;
            if (time >= Spawntime)
            {

                Instantiate(Rocket, transform.position, transform.rotation);
                time = 0;
            }
        }
    }
}
