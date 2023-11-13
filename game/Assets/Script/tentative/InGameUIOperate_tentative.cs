using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUIOperate_tentative : MonoBehaviour
{
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject SuccessUI;
    [SerializeField] GameObject PauseUI;
    [SerializeField] Clear clear;
    string sceneName;



    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverUI.activeSelf)
        {
            if (Input.GetKeyDown("joystick button 2")) //Xボタン
            {
                switch (sceneName)
                {
                    case "FirstStage":
                        SceneManager.LoadScene("FirstStage");
                        break;
                    case "SecondStage":
                        SceneManager.LoadScene("SecondStage");
                        break;
                    case "ThirdStage":
                        SceneManager.LoadScene("ThirdStage");
                        break;
                    case "FifthStage":
                        SceneManager.LoadScene("FifthStage");
                        break;
                }
            }
            else if (Input.GetKeyDown("joystick button 1")) //Bボタン
            {
                SceneManager.LoadScene("MainMenuNew"); ;
            }           
        }
        else if (SuccessUI.activeSelf)
        {
            if (Input.GetKeyDown("joystick button 2")) //Xボタン
            {
                clear.ToNextStage();
            }
            else if (Input.GetKeyDown("joystick button 1")) //Bボタン
            {
                clear.BackMainMenu();
            }           
        }
        else if (PauseUI.activeSelf)
        {
            if (Input.GetKeyDown("joystick button 2")) //Xボタン
            {
                switch (SceneManager.GetActiveScene().name)
                {
                    case "FirstStage":
                        SceneManager.LoadScene("FirstStage");
                        break;
                    case "SecondStage":
                        SceneManager.LoadScene("SecondStage");
                        break;
                    case "ThirdStage":
                        SceneManager.LoadScene("ThirdStage");
                        break;
                    case "FifthStage":
                        SceneManager.LoadScene("FifthStage");
                        break;
                }
            }
            else if (Input.GetKeyDown("joystick button 0"))//Aボタン
            {
                SceneManager.LoadScene("MainMenuNew");
            }
            else if (Input.GetKeyDown("joystick button 1")) //Bボタン
            {
                SceneManager.LoadScene("Option");
            }
        }
    }
}
