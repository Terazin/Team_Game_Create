using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InGame_UI_Show : MonoBehaviour
{
    [SerializeField] GameObject operationInstructon;
    [SerializeField] GameObject MapView;
    [SerializeField] GameObject gameSceneUI; //X,Yボタンの処理が行われる際、通常UIを消すために宣言
    [SerializeField] GameObject Pause;
    [SerializeField] GameObject Option;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject TimeOverUI;
    [SerializeField] GameObject SuccessUI;
    [SerializeField] PopupScript popupScript; //インゲーム冒頭のマップ表示を管理しているPopupScriptを宣言


    [SerializeField] Button pauseFirstButton; //ポーズの初期選択ボタン
    [SerializeField] Button optionFirstButton; //オプションの初期選択ボタン
    [SerializeField] Button timeOverFirstButton; //タイムオーバーの初期選択ボタン
    [SerializeField] Button gameOverFirstButton; //ゲームオーバーの初期選択ボタン

    //public AudioSource audioSource;
    //public AudioClip selectSound;
    //public AudioClip decideSound;

    //AudioSource audioSource_;

    //-- bool変数(他のボタンが反応しないためや、二度と処理を行わないようにするため。) --//

    bool Is_X_Push = false; //Xボタンが押されているか
    bool Is_Y_Push = false; //Yボタンが押されているか
    bool Is_START_Push = false; //STARTボタンが押されているか
    bool Is_Option_Push = false; //pauseのoptionボタンが押されたか
    bool Is_Popup_Show = false; //マップが表示されたか
    bool IsTimeOver = false; //TimeOverが表示されているか
    bool IsGameOver = false; //GameOverが表示されているか



    // Start is called before the first frame update
    void Start()
    {
        popupScript.Appear(); //Start()関数を使って、一度だけAppear()を実行 マップを表示
        Is_Popup_Show = true; //シーンで一度だけ処理を行うようにするために必要
        gameSceneUI.SetActive(false);
        //audioSource_ = audioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Is_Popup_Show) //インゲーム冒頭マップ表示処理
        {
            SetGamePaused(true);
            if (Input.GetKeyDown("joystick button 3")) //Aボタンを検知
            {
                popupScript.Delete();
                Is_Popup_Show = false; //このシーンが終わるまで、このboolがtrueになることは無い。
                gameSceneUI.SetActive(true);
                SetGamePaused(false);
            }
        }
        else
        {
            //XボタンとYボタンとSTARTボタンの検知

            if (!Is_X_Push && !Is_Y_Push && !Is_START_Push && !GameOverUI.activeSelf && !SuccessUI.activeSelf && !TimeOverUI.activeSelf)    //一方のボタンが押されたとき、他のボタンの動作が行われないようにする。
            {
                if (Input.GetKeyDown("joystick button 2")) //Xボタンが押されたときの処理
                {
                    operationInstructon.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_X_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 3")) //Yボタンが押されたときの処理
                {
                    MapView.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_Y_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 7")) //STARTボタンが押されたときの処理
                {
                    Pause.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_START_Push = true;
                    //初期選択ボタンの初期化
                    EventSystem.current.SetSelectedGameObject(null);
                    //初期選択ボタンの再指定
                    pauseFirstButton.Select();
                }
            }
            else
            {
                if ((Input.GetKeyDown("joystick button 2")) && Is_X_Push) //もう一度Xボタンが押されたときの処理
                {
                    operationInstructon.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_X_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 3")) && Is_Y_Push) //もう一度Yボタンが押されたときの処理
                {
                    MapView.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_Y_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 7")) && Is_START_Push && !Is_Option_Push)  //もう一度STARTボタンが押されたときの処理
                {
                    Pause.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_START_Push = false;
                }
                else if (TimeOverUI.activeSelf && !IsTimeOver) //タイムオーバー画面が表示されたとき。IsTimeOverで一度だけ処理にしている。
                {
                    EventSystem.current.SetSelectedGameObject(null);
                    timeOverFirstButton.Select();
                    gameSceneUI.SetActive(false);
                    IsTimeOver = true;
                }
                else if (GameOverUI.activeSelf && !IsGameOver) //ゲームオーバー画面が表示されたとき。IsTimeOverで一度だけ処理にしている。
                {
                    EventSystem.current.SetSelectedGameObject(null);
                    gameOverFirstButton.Select();
                    gameSceneUI.SetActive(false);
                    IsGameOver = true;
                }
            }
        }
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void optionPush() //pauseのoptionボタンのOnClick()に登録
    {
        Pause.SetActive(false);
        Option.SetActive(true);
        //初期選択ボタンの初期化
        EventSystem.current.SetSelectedGameObject(null);
        //初期選択ボタンの再指定
        optionFirstButton.Select();
        Is_Option_Push = true;
    }

    public void backPush() //optionのbackボタンのOnClick()に登録
    {
        Option.SetActive(false);
        Pause.SetActive(true);
        //初期選択ボタンの初期化
        EventSystem.current.SetSelectedGameObject(null);
        //初期選択ボタンの再指定
        pauseFirstButton.Select();
        Is_Option_Push = false;
    }
}
