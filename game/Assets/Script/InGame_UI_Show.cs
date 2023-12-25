using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InGame_UI_Show : MonoBehaviour
{
    [SerializeField] GameObject operationInstructon;
    [SerializeField] GameObject MapView;
    [SerializeField] GameObject gameSceneUI; //X,Y�{�^���̏������s����ہA�ʏ�UI���������߂ɐ錾
    [SerializeField] GameObject Pause;
    [SerializeField] GameObject Option;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject TimeOverUI;
    [SerializeField] GameObject SuccessUI;
    [SerializeField] PopupScript popupScript; //�C���Q�[���`���̃}�b�v�\�����Ǘ����Ă���PopupScript��錾


    [SerializeField] Button pauseFirstButton; //�|�[�Y�̏����I���{�^��
    [SerializeField] Button optionFirstButton; //�I�v�V�����̏����I���{�^��
    [SerializeField] Button timeOverFirstButton; //�^�C���I�[�o�[�̏����I���{�^��
    [SerializeField] Button gameOverFirstButton; //�Q�[���I�[�o�[�̏����I���{�^��

    //public AudioSource audioSource;
    //public AudioClip selectSound;
    //public AudioClip decideSound;

    //AudioSource audioSource_;

    //-- bool�ϐ�(���̃{�^�����������Ȃ����߂�A��x�Ə������s��Ȃ��悤�ɂ��邽�߁B) --//

    bool Is_X_Push = false; //X�{�^����������Ă��邩
    bool Is_Y_Push = false; //Y�{�^����������Ă��邩
    bool Is_START_Push = false; //START�{�^����������Ă��邩
    bool Is_Option_Push = false; //pause��option�{�^���������ꂽ��
    bool Is_Popup_Show = false; //�}�b�v���\�����ꂽ��
    bool IsTimeOver = false; //TimeOver���\������Ă��邩
    bool IsGameOver = false; //GameOver���\������Ă��邩



    // Start is called before the first frame update
    void Start()
    {
        popupScript.Appear(); //Start()�֐����g���āA��x����Appear()�����s �}�b�v��\��
        Is_Popup_Show = true; //�V�[���ň�x�����������s���悤�ɂ��邽�߂ɕK�v
        gameSceneUI.SetActive(false);
        //audioSource_ = audioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Is_Popup_Show) //�C���Q�[���`���}�b�v�\������
        {
            SetGamePaused(true);
            if (Input.GetKeyDown("joystick button 3")) //A�{�^�������m
            {
                popupScript.Delete();
                Is_Popup_Show = false; //���̃V�[�����I���܂ŁA����bool��true�ɂȂ邱�Ƃ͖����B
                gameSceneUI.SetActive(true);
                SetGamePaused(false);
            }
        }
        else
        {
            //X�{�^����Y�{�^����START�{�^���̌��m

            if (!Is_X_Push && !Is_Y_Push && !Is_START_Push && !GameOverUI.activeSelf && !SuccessUI.activeSelf && !TimeOverUI.activeSelf)    //����̃{�^���������ꂽ�Ƃ��A���̃{�^���̓��삪�s���Ȃ��悤�ɂ���B
            {
                if (Input.GetKeyDown("joystick button 2")) //X�{�^���������ꂽ�Ƃ��̏���
                {
                    operationInstructon.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_X_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 3")) //Y�{�^���������ꂽ�Ƃ��̏���
                {
                    MapView.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_Y_Push = true;
                }
                else if (Input.GetKeyDown("joystick button 7")) //START�{�^���������ꂽ�Ƃ��̏���
                {
                    Pause.SetActive(true);
                    gameSceneUI.SetActive(false);
                    Is_START_Push = true;
                    //�����I���{�^���̏�����
                    EventSystem.current.SetSelectedGameObject(null);
                    //�����I���{�^���̍Ďw��
                    pauseFirstButton.Select();
                }
            }
            else
            {
                if ((Input.GetKeyDown("joystick button 2")) && Is_X_Push) //������xX�{�^���������ꂽ�Ƃ��̏���
                {
                    operationInstructon.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_X_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 3")) && Is_Y_Push) //������xY�{�^���������ꂽ�Ƃ��̏���
                {
                    MapView.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_Y_Push = false;
                }
                else if ((Input.GetKeyDown("joystick button 7")) && Is_START_Push && !Is_Option_Push)  //������xSTART�{�^���������ꂽ�Ƃ��̏���
                {
                    Pause.SetActive(false);
                    gameSceneUI.SetActive(true);
                    Is_START_Push = false;
                }
                else if (TimeOverUI.activeSelf && !IsTimeOver) //�^�C���I�[�o�[��ʂ��\�����ꂽ�Ƃ��BIsTimeOver�ň�x���������ɂ��Ă���B
                {
                    EventSystem.current.SetSelectedGameObject(null);
                    timeOverFirstButton.Select();
                    gameSceneUI.SetActive(false);
                    IsTimeOver = true;
                }
                else if (GameOverUI.activeSelf && !IsGameOver) //�Q�[���I�[�o�[��ʂ��\�����ꂽ�Ƃ��BIsTimeOver�ň�x���������ɂ��Ă���B
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

    public void optionPush() //pause��option�{�^����OnClick()�ɓo�^
    {
        Pause.SetActive(false);
        Option.SetActive(true);
        //�����I���{�^���̏�����
        EventSystem.current.SetSelectedGameObject(null);
        //�����I���{�^���̍Ďw��
        optionFirstButton.Select();
        Is_Option_Push = true;
    }

    public void backPush() //option��back�{�^����OnClick()�ɓo�^
    {
        Option.SetActive(false);
        Pause.SetActive(true);
        //�����I���{�^���̏�����
        EventSystem.current.SetSelectedGameObject(null);
        //�����I���{�^���̍Ďw��
        pauseFirstButton.Select();
        Is_Option_Push = false;
    }
}
