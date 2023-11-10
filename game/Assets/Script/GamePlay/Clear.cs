using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField] CanvasGroup gameSceneUI;
    public int enemyNum; //敵の数（Componentから設定可能）
    public int destroyCount;
    public string NextStage; //ここに次のステージのScene名を入れる。
    public CanvasGroup successShow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyCount == enemyNum)
        {
            successShow.alpha = 1f;
            gameSceneUI.alpha = 0f;
        }
    }

    public void ToNextStage()
    {
        successShow.alpha = 0;
        SceneManager.LoadScene(NextStage);
    }

    public void BackMainMenu()
    {
        successShow.alpha = 0;
        SceneManager.LoadScene("Main_menu");
    }
}
