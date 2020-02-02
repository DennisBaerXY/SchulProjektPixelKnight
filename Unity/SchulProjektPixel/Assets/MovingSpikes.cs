using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikes : MonoBehaviour
{

    Vector3 target;
    public float speed;
    public float Distance;
    public bool activate;
    public bool up, down, left, right;
    public bool stay;
    // Start is called before the first frame update
    void Start()
    {
        if (left)
        {
            target = new Vector3(transform.position.x - Distance, transform.position.y, transform.position.z);
          
            down = false;
            up = false;
            right = false;

        }
        if (right)
        {
            target = new Vector3(transform.position.x + Distance, transform.position.y, transform.position.z);
            left = false;
            down = false;
            up = false;
            
        }
        if (up)
        {
            target = new Vector3(transform.position.x , transform.position.y + Distance, transform.position.z);
            left = false;
            down = false;
            up = false;
            right = false;
        }
         if (down)
        {
            target = new Vector3(transform.position.x, transform.position.y - Distance, transform.position.z);
            left = false;
            
            up = false;
            right = false;
        }

       

    }

    // Update is called once per frame
    void Update()
    {
       
        
        
           if (activate)
           {
               transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
           }
        
        

    }
}
