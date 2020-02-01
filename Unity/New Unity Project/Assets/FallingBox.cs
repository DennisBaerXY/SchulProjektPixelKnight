using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBox : MonoBehaviour
{
    RaycastCommand ray;
    Ray Raycasted;
    RaycastHit hit;
    public float distance  =10;
    void Start()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.green);


    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(new Ray(transform.position,Vector3.down),distance))
        {
            print("Hit Ground");
            transform.position = new Vector3(transform.position.x, 50, transform.position.z);
        }
    }
}
