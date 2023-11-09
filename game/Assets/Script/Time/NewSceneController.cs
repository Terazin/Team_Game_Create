using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneController : MonoBehaviour
{
    void Start()
    {
        int isGamePaused = PlayerPrefs.GetInt("IsGamePaused", 0);
        if (isGamePaused == 1)
        {
            Debug.Log("Game is not paused."); // デバッグログを追加
            Time.timeScale = 1.0f; // ゲームの時間を停止
        }
       
    }

    // シーン遷移ボタンが押された場合に呼び出すメソッド
    public void ChangeScene(string sceneName)
    {
        ResumeGame(); // シーン遷移前に時間を再開
        SceneManager.LoadScene(sceneName); // シーンを切り替える
    }

    void ResumeGame()
    {
        Time.timeScale = 1.0f; // ゲームを再開
    }
}
