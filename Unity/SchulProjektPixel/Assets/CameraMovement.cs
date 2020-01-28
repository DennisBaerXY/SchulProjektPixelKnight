using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, CameraHeight(Player), -10);
    }

    public float CameraHeight(GameObject Player)
    {
        float wert = 0;
        if (Player.transform.position.y <= 5 && Player.transform.position.y >= -5)
        {
            wert = 0;
        }

        if (Player.transform.position.y <= -5 && Player.transform.position.y >= -15)
        {
            wert = -10;
        }

        if (Player.transform.position.y <= 15 && Player.transform.position.y >= 5)
        {
            wert =  10;
        }

        return wert;
    }
}
