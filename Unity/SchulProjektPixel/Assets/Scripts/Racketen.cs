using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Racketen : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    public GameObject particleExplosion;
   

    void Start()
    {
        target = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            Instantiate(particleExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(particleExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            StartCoroutine("Wow");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }

    IEnumerable Wow()
    {
        yield return new WaitForSeconds(1f);
    }

}

