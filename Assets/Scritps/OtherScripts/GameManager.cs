using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public string namePlayer;
    public string bestPlayer;
    public int bestScore;
    
    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int score;
    }

    public void SaveHighScore() 
    {
        SaveData data = new SaveData();
        data.name = bestPlayer;
        data.score = bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore() 
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.score;
            bestPlayer = data.name;
        }
    }

}
