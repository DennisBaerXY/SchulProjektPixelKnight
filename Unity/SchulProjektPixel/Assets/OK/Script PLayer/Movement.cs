using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isGrounded = false;
    public float speed;
    public float jumpfHeight;
    Vector3 movementX;

   

   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {

        Jump();
    }


    private void FixedUpdate()
    {
     
        movementX = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.position += movementX * Time.fixedDeltaTime * speed;

        


    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpfHeight), ForceMode2D.Impulse);
        }
        
    }
    
}
