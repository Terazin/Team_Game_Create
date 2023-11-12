using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    public float Timer = 60;
    public Text TimerText;
    public GameObject Game0verWindow;
    [SerializeField] GameObject gameSceneUI;
    [SerializeField] GameObject operationInstructon;
    [SerializeField] GameObject MapView;
    // Start is called before the first frame update
    void Start()
    {
        SetGamePaused(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (operationInstructon.activeSelf || MapView.activeSelf)
        {
            SetGamePaused(true);
        }
        else
        {
            SetGamePaused(false);
        }

        if (gameSceneUI.activeSelf)
        {
            Timer -= Time.deltaTime;
            TimerText.text = ((int)Timer).ToString();

            if (Timer <= 0)
            {
                Game0verWindow.SetActive(true);
                gameSceneUI.SetActive(false);
                enabled = false;
                SetGamePaused(true); // ƒQ[ƒ€‚ÌŽžŠÔ‚ð’âŽ~
                PlayerPrefs.SetInt("IsGamePaused", 1);
            }
        }     
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }
}
