using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReserch : MonoBehaviour
{
    [SerializeField] ShotGun shotGun;
    string sceneName;
    public int bulletRefLimit;
    public int bulletRefCount;
 
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
                bulletRefLimit = 7;
                break;
            case "EighthStage":
                bulletRefLimit = 4;
                break;
            case "NinethStage":
                bulletRefLimit = 5;
                break;
            case "TenthStage":
                bulletRefLimit = 9;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Setting(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if ((bulletRefLimit != 0) && (bulletRefCount != 0))
        {
            if (bulletRefCount == bulletRefLimit)
            {
                Destroy(shotGun.bulletDel);

            }
        }
    }

}
