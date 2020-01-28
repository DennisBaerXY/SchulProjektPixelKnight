using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class BallScript : MonoBehaviour
{
    GameManagement gameManagement;
    public GameObject gameManager;

    public float BallValue = 50f;
    

    private void Start()
    {
        gameManagement = gameManager.GetComponent<GameManagement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Debug.Log("HIT FLOOR");
            GameManagement.addMoney(BallValue);
            Destroy(gameObject);
           


        }
    }
}
