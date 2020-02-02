using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Camera : MonoBehaviour
{
    public GameObject camera;
    public bool down, up;
    public float cameraDistance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (down)
        {
            camera.transform.position = new Vector3(camera.transform.position.x, -52, camera.transform.position.z);
        }
        if (up)
        {
            camera.transform.position = new Vector3(camera.transform.position.x, -35  , camera.transform.position.z);
        }
    }
}
