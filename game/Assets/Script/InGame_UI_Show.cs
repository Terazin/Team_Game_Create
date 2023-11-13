using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_UI_Show : MonoBehaviour
{
    [SerializeField] GameObject operationInstructon;
    [SerializeField] GameObject MapView;
    [SerializeField] GameObject gameSceneUI; //X,Yボタンの処理が行われる際、通常UIを消すために宣言
    [SerializeField] GameObject Pause;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject SuccessUI;
    [SerializeField] PopupScript popupScript; //インゲーム冒頭のマップ表示を管理しているPopupScriptを宣言
    
    bool Is_X_Push = false; //Xボタンが押されているか
    bool Is_Y_Push = false; //Yボタンが押されているか
    bool Is_START_Push = false; //STARTボタンが押されているか
    bool Is_Popup_Show = false; //マップが表示されたか

    

    // Start is called before the first frame update
    void Start()
    {
        popupScript.Appear(); //Start()関数を使って、一度だけAppear()を実行 マップを表示
        Is_Popup_Show = true; //シーンで一度だけ処理を行うようにするために必要
        gameSceneUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //インゲーム冒頭マップ表示処理

        if (Is_Popup_Show)
        {
            SetGamePaused(true);
            if (Input.GetKeyDown("joystick button 1")) //Aボタンを検知
            {
                popupScript.Delete();
                Is_Popup_Show = false; //このシーンが終わるまで、このboolがtrueになることは無い。
                gameSceneUI.SetActive(true);
                SetGamePaused(false);
            }
        }
        else
        {
            //XボタンとYボタンの検知

            if (!Is_X_Push && !Is_Y_Push && !Is_START_Push && !GameOverUI.activeSelf && !SuccessUI.activeSelf)   //一方のボタンが押されたとき、他のボタンの動作が行われないようにする。
            {
                if (Input.GetKeyDown("joystick button 2"))
                {
                    operationInstructon.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_X_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 3"))
                {
                    MapView.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_Y_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 7"))
                {
                    Pause.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_START_Push = true;
                }
            }
            else
            {
                if ((Input.GetKeyDown("joystick button 2")) && Is_X_Push)
                {
                    operationInstructon.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_X_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 3")) && Is_Y_Push)
                {
                    MapView.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_Y_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 7")) && Is_START_Push)
                {
                    Pause.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_START_Push = false;
                }
            }
        }       
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }
}
