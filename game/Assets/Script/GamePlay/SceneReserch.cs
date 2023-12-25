using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReserch : MonoBehaviour
{
    [SerializeField] ShotGun shotGun;
    string sceneName;
    public int bulletRefLimit; //各ステージの反射上限の定義（処理の関係上、上限に+1した値を代入）
    public int bulletRefCount; //反射した回数を格納
    public bool IsBulletDelete = false;
 
    void Setting(string name)
    {
        switch (name) //反射回数の定義(処理の関係上、反射回数に+1した値になっている。)
        {
            case "FirstStage":
                bulletRefLimit = 2;
                break;
            case "SecondStage":
                bulletRefLimit = 5;
                break;
            case "ThirdStage":
                bulletRefLimit = 6;
                break;
            case "FourthStage":
                bulletRefLimit = 3;
                break;
            case "FifthStage":
                bulletRefLimit = 8;
                break;
            case "SixthStage":
                bulletRefLimit = 3;
                break;
            case "SeventhStage":
                bulletRefLimit = 10;
                break;
            case "EighthStage":
                bulletRefLimit = 5;
                break;
            case "NinthStage":
                bulletRefLimit = 11;
                break;
            case "TenthStage":
                bulletRefLimit = 7;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name; //現在のシーン名の取得
        Setting(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if ((bulletRefLimit != 0) && (bulletRefCount != 0))
        {
            if (bulletRefCount == bulletRefLimit)
            {
                Destroy(shotGun.bulletDel); //弾を消す方法が思いつかなかったため、シーン上に弾のインスタンスを作るために宣言したGameObject変数を呼び出している。
                IsBulletDelete = true;
            }
        }
    }

}
