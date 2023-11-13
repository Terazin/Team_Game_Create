using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField] GameObject gameSceneUI;
    [SerializeField] SceneReserch sceneReserch;
    public GameObject GameOverWindow;
    public int enemyNum; //�G�̐��iComponent����ݒ�\�j
    public int destroyCount;
    public string NextStage; //�����Ɏ��̃X�e�[�W��Scene��������B
    public GameObject successShow;

    // Start is called before the first frame update
    void Start()
    {
        SetGamePaused(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyCount == enemyNum) && sceneReserch.IsBulletDelete)
        {
            successShow.SetActive(true);
            gameSceneUI.SetActive(false);
            SetGamePaused(true);
        }
        else if ((destroyCount != enemyNum) && sceneReserch.IsBulletDelete)
        {
            GameOverWindow.SetActive(true);
            gameSceneUI.SetActive(false);
            enabled = false;
            SetGamePaused(true); // �Q�[���̎��Ԃ��~
        }

        
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void ToNextStage()
    {
        successShow.SetActive(false);
        SceneManager.LoadScene(NextStage);
    }

    public void BackMainMenu()
    {
        successShow.SetActive(false);
        SceneManager.LoadScene("MainMenuNew");
    }
}
