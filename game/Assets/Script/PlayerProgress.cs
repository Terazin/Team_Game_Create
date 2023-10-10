using System;
using System.IO;
using UnityEngine;

[Serializable]
public class PlayerProgress
{
    public int stageNum;

    public PlayerProgress(int initialStageNum)
    {
        stageNum = initialStageNum;
    }
}

public static class SaveSystem
{
    public static void SavePlayerProgress(PlayerProgress progress)
    {
        string path = Application.persistentDataPath + "/playerProgress.json";
        string json = JsonUtility.ToJson(progress);
        File.WriteAllText(path, json);
    }

    public static PlayerProgress LoadPlayerProgress()
    {
        string path = Application.persistentDataPath + "/playerProgress.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<PlayerProgress>(json);
        }
        else
        {
            return new PlayerProgress(0); // èâä˙ílÇÕ0
        }
    }
}
