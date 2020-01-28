using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    float time;
    public float saveInterval;
    public Text moneyText;
   static public float money;


    static public void addMoney(float m)
    {
        money += m;
    }












    private void Start()
    {
        //Loading
        GameData data = SaveSystem.LoadGameData();
        money = data.money;
    }




    public void SaveGameData()
    {
        SaveSystem.SaveGame(this);
        Debug.Log("Saved");
    }



    private void Update()
    {
        time = time + 1f * Time.deltaTime;
    
        if (time >= saveInterval )
        {
            SaveGameData();
        }


        moneyText.text = "Money: " + money;
    }
}
