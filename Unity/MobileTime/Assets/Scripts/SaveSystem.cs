using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static  class SaveSystem 
{
   public static void SaveGame(GameManagement gameData)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameData.wow";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gameData);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadGameData()
    {
        string path = Application.persistentDataPath + "/gameData.wow";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

    }
}
