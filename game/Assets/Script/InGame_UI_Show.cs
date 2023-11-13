using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_UI_Show : MonoBehaviour
{
    [SerializeField] GameObject operationInstructon;
    [SerializeField] GameObject MapView;
    [SerializeField] GameObject gameSceneUI; //X,Y�{�^���̏������s����ہA�ʏ�UI���������߂ɐ錾
    [SerializeField] GameObject Pause;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject SuccessUI;
    [SerializeField] PopupScript popupScript; //�C���Q�[���`���̃}�b�v�\�����Ǘ����Ă���PopupScript��錾
    
    bool Is_X_Push = false; //X�{�^����������Ă��邩
    bool Is_Y_Push = false; //Y�{�^����������Ă��邩
    bool Is_START_Push = false; //START�{�^����������Ă��邩
    bool Is_Popup_Show = false; //�}�b�v���\�����ꂽ��

    

    // Start is called before the first frame update
    void Start()
    {
        popupScript.Appear(); //Start()�֐����g���āA��x����Appear()�����s �}�b�v��\��
        Is_Popup_Show = true; //�V�[���ň�x�����������s���悤�ɂ��邽�߂ɕK�v
        gameSceneUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�C���Q�[���`���}�b�v�\������

        if (Is_Popup_Show)
        {
            SetGamePaused(true);
            if (Input.GetKeyDown("joystick button 1")) //A�{�^�������m
            {
                popupScript.Delete();
                Is_Popup_Show = false; //���̃V�[�����I���܂ŁA����bool��true�ɂȂ邱�Ƃ͖����B
                gameSceneUI.SetActive(true);
                SetGamePaused(false);
            }
        }
        else
        {
            //X�{�^����Y�{�^���̌��m

            if (!Is_X_Push && !Is_Y_Push && !Is_START_Push && !GameOverUI.activeSelf && !SuccessUI.activeSelf)   //����̃{�^���������ꂽ�Ƃ��A���̃{�^���̓��삪�s���Ȃ��悤�ɂ���B
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
