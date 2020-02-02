using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;


public class TileMapScript : MonoBehaviour
{
    public GameObject gm;
    private GameLevelManager glm;
    private void Start()
    {
        glm = gm.GetComponent<GameLevelManager>();
    }
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameLevelManager.AddDeath();
            
            print("Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
