using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    public float Distance;
    public float speed;

    public bool isGoingUp = false;

    Vector3 target;
    private Vector3 targetDown;
    private bool isGoingLeft = true;
    public bool Updown = false;

    void Start()
    {
        target = new Vector3(transform.position.x - Distance, transform.position.y, transform.position.z);
        targetDown = new Vector3(transform.position.x, transform.position.y - Distance, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {


        if (Updown)
        {


            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == targetDown && isGoingUp)
            {
                isGoingUp = !isGoingUp;
                targetDown = new Vector3(transform.position.x, transform.position.y + Distance, transform.position.z);
            }
            if (transform.position == targetDown && !isGoingUp)
            {
                isGoingUp = !isGoingUp;
                targetDown = new Vector3(transform.position.x, transform.position.y - Distance, transform.position.z);
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target && isGoingLeft)
            {
                isGoingLeft = !isGoingLeft;
                target = new Vector3(transform.position.x + Distance, transform.position.y, transform.position.z);
            }
            if (transform.position == target && !isGoingLeft)
            {
                isGoingLeft = !isGoingLeft;
                target = new Vector3(transform.position.x - Distance, transform.position.y, transform.position.z);
            }
        }


    }
}
