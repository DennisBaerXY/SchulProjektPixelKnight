using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isGrounded = false;
    public float speed;
    public float jumpfHeight;
    Vector3 movementX;
    bool looksright = true;
    public GameObject manager;
    GameLevelManager gamemanager;

    public bool Godmode;




    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gamemanager = manager.GetComponent<GameLevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetAxis("Horizontal") > 0 && !looksright || Input.GetAxis("Horizontal") < 0 && looksright)
        {
            Flip();
        }
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

    void Flip()
    {
        looksright = !looksright;
        Vector3 Charflip = transform.localScale;
        Charflip.x *= -1;


        transform.localScale = Charflip;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Weapon")
        {
            GameLevelManager.AddDeath();
            print("Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                


            
           
        }

       
    }

   
}
