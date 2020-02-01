using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    public float Distance;
    public float speed;
    Vector3 target;
    private bool isGoingLeft = true;

    void Start()
    {
        target = new Vector3(transform.position.x - Distance, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
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
