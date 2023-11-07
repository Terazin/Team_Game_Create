using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    public float Timer = 60;
    public Text TimerText;
    public GameObject Game0verWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        TimerText.text= ((int)Timer).ToString();

        if (Timer<=0 )
        {
            Game0verWindow.SetActive(true);
            enabled = false;
            SetGamePaused(true); // ƒQ[ƒ€‚ÌŽžŠÔ‚ð’âŽ~
            PlayerPrefs.SetInt("IsGamePaused", 1);
        }
        void SetGamePaused(bool isPaused)
        {
            Time.timeScale = isPaused ? 0.0f : 1.0f;
        }
    }
}
