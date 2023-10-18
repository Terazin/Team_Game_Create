using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public int enemyNum; //敵の数（Componentから設定可能）
    public int destroyCount;
    public string NextStage; //ここに次のステージのScene名を入れる。

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyCount == enemyNum)
        {
            SceneManager.LoadScene(NextStage);
        }
    }


}
