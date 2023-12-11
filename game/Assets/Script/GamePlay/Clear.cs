using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    [SerializeField] GameObject gameSceneUI;
    [SerializeField] SceneReserch sceneReserch;
    [SerializeField] Button successFirstButton;
    [SerializeField] Button gameOverFirstButton;

    public GameObject GameOverWindow;
    public int enemyNum; //敵の数（Componentから設定可能）
    public int destroyCount;
    public string NextStage; //ここに次のステージのScene名を入れる。
    public GameObject successShow;

    bool IsSuccess = false;
    bool IsGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        SetGamePaused(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((destroyCount == enemyNum) && sceneReserch.IsBulletDelete && !IsSuccess && !IsGameOver) 
        {
            StartCoroutine(SuccessJudge());
        }
        else if ((destroyCount != enemyNum) && sceneReserch.IsBulletDelete && !IsSuccess && !IsGameOver)
        {
            StartCoroutine(SuccessJudge());
        }       
    }

    private IEnumerator SuccessJudge(){

        yield return new WaitForSeconds(1.5f);

        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemyObjects.Length == 0) 
        {
            successShow.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            successFirstButton.Select();
            gameSceneUI.SetActive(false);
            SetGamePaused(true);
            IsSuccess = true;
        }
        else
        {
            GameOverWindow.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            gameOverFirstButton.Select();
            gameSceneUI.SetActive(false);
            enabled = false;
            SetGamePaused(true); // ゲームの時間を停止
            IsGameOver = true;
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
