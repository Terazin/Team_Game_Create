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
            Debug.Log("Game is not paused."); // �f�o�b�O���O��ǉ�
            Time.timeScale = 1.0f; // �Q�[���̎��Ԃ��~
        }
       
    }

    // �V�[���J�ڃ{�^���������ꂽ�ꍇ�ɌĂяo�����\�b�h
    public void ChangeScene(string sceneName)
    {
        ResumeGame(); // �V�[���J�ڑO�Ɏ��Ԃ��ĊJ
        SceneManager.LoadScene(sceneName); // �V�[����؂�ւ���
    }

    void ResumeGame()
    {
        Time.timeScale = 1.0f; // �Q�[�����ĊJ
    }
}
