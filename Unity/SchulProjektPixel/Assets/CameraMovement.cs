using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject gameEndPoint;
    public float speed;
    public float borderDistanceX;
    public float borderDistanceY;

    public float border;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        borderDistanceX = System.Math.Abs( transform.position.x - Player.transform.position.x);
        borderDistanceY = System.Math.Abs( transform.position.y - Player.transform.position.y);
        if (borderDistanceX <= 4 || borderDistanceY <= 4)
        {
            speed = 1f;
        }

        if (borderDistanceX > 4 || borderDistanceY > 4)
        {
            
                speed = 2f;
            
        }
       
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, -10), new Vector3(Player.transform.position.x, Player.transform.position.y, -10), speed * Time.deltaTime);

    }



}
