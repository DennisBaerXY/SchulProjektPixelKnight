using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLevelManager : MonoBehaviour
{
    public static bool level1 = false, level2 = false, level3 = false;
    public static bool level1Finished, level2Finished, level3Finished;
    int level;
   public static int deathsThisLevel = 0;

    public Text deathCounter;
    public GameObject Pausemenu;
    public static int deaths = 0;
    public static int apples = 0;

    public Button a1,a2,a3;
    private bool isOpen = false;


    public Text deathsTotalPause;
    public Text deathsThisLevelPause;
    public Text ApplesCollected;


    // Start is called before the first frame update
    void Start()
    {
        level1Finished = bool.Parse( PlayerPrefs.GetString("level1Finished", "false"));
        level2Finished = bool.Parse(PlayerPrefs.GetString("level2Finished", "false"));
        level3Finished = bool.Parse(PlayerPrefs.GetString("level3Finished", "false"));

        deaths = PlayerPrefs.GetInt("Deaths", 0);


        if (level1Finished)
        {
            a2.interactable = true;
        }

        if (level2Finished)
        {
            a3.interactable = true;
        }

      


        level = SceneManager.GetActiveScene().buildIndex;
        switch (level)
        {
            case 1: 
                level1 = true;
                level2 = false;
                level3 = false;
                break;

            case 2:
                
                level1 = false;
                level2 = true;
                level3 = false;
                break;

            case 3:
               
                level1 = false;
                level2 = false;
                level3 = true;

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        deathCounter.text = "Death Counter: " + deaths.ToString();








        if (Input.GetKeyDown("escape"))
        {
            if (isOpen)
            {
                isOpen = !isOpen; 
                Pausemenu.SetActive(false);
                Time.timeScale = 1;
            }

            else
            {
                isOpen = !isOpen;
                Pausemenu.SetActive(true);
                Time.timeScale = 0;
            }
        }

        deathsTotalPause.text = "Deaths Total: " + deaths;
        deathsThisLevelPause.text = "Deaths this level: " + deathsThisLevel;
        ApplesCollected.text = "Appels Collected: " + apples;
        
        PlayerPrefs.SetInt("Deaths", deaths);
        


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (level1)
        {
            PlayerPrefs.SetString("level1Finished", "true");
            level1Finished = true;
            
        }
        if (level2)
        {
            PlayerPrefs.SetString("level2Finished", "true");
            level2Finished = true;
        }

        if (level3)
        {
            PlayerPrefs.SetString("level3Finished", "true");
            level3Finished = true;
        }

        SceneManager.LoadScene(0);
    }

    public void Load1()
    {
        deathsThisLevel = 0;
        SceneManager.LoadScene(1);
    }

    public void Load2()
    {
        deathsThisLevel = 0;
        SceneManager.LoadScene(2);
    }

    public void Load3()
    {
        deathsThisLevel = 0;
        SceneManager.LoadScene(3);
    }


    public void Reset()
    {
        PlayerPrefs.SetString("level1Finished", "false");
        PlayerPrefs.SetString("level2Finished", "false");
        PlayerPrefs.SetString("level3Finished", "false");
        PlayerPrefs.SetInt("Deaths", 0);

        PlayerPrefs.SetString("level1Finished", "false");
     
        PlayerPrefs.SetString("level2Finished", "false");
        

    }
            
         
    

  

  
    public static void AddDeath()
    {
        deaths++;
        deathsThisLevel++;
        
        print("DeathAdded");
        PlayerPrefs.SetInt("Deaths", deaths);


       
    }


    public void loadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
   


}
