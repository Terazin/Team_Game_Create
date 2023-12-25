using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseTest : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject option;
    [SerializeField] Button focusButton;
    [SerializeField] Button optionFirstButton;
    bool IsPush;
    bool IsOptionPush;

    // Start is called before the first frame update
    void Start()
    {
        IsPush = false;
        IsOptionPush = false;
        focusButton = focusButton.GetComponent<Button>();
        optionFirstButton = optionFirstButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !IsPush)
        {
            panel.SetActive(true);
            IsPush = true;
            //初期選択ボタンの初期化
            EventSystem.current.SetSelectedGameObject(null);
            //初期選択ボタンの再指定
            focusButton.Select();
        }
        else if (Input.GetKeyDown(KeyCode.Q) && IsPush && !IsOptionPush) 
        {
            panel.SetActive(false);
            IsPush = false;
        }

    }

    public void optionPush() //pauseのoptionボタンのOnClick()に登録
    {
        panel.SetActive(false);
        option.SetActive(true);
        //初期選択ボタンの初期化
        EventSystem.current.SetSelectedGameObject(null);
        //初期選択ボタンの再指定
        optionFirstButton.Select();
        IsOptionPush = true;
    }

    public void backPush() //optionのbackボタンのOnClick()に登録
    {
        option.SetActive(false);
        panel.SetActive(true);
        //初期選択ボタンの初期化
        EventSystem.current.SetSelectedGameObject(null);
        //初期選択ボタンの再指定
        focusButton.Select();
        IsOptionPush = false;
    }
}
