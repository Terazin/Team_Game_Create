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
        switch (name) //îΩéÀâÒêîÇÃíËã`
        {
            case "FirstStage":
                bulletRefLimit = 3;
                break;
            case "SecondStage":
                bulletRefLimit = 3;
                break;
            case "ThirdStage":
                bulletRefLimit = 5;
                break;
            case "FourthStage":
                bulletRefLimit = 2;
                break;
            case "FifthStage":
                bulletRefLimit = 4;
                break;
            case "SixthStage":
                bulletRefLimit = 4;
                break;
            case "SeventhStage":
                bulletRefLimit = 6;
                break;
            case "EighthStage":
                bulletRefLimit = 3;
                break;
            case "NinethStage":
                bulletRefLimit = 4;
                break;
            case "TenthStage":
                bulletRefLimit = 8;
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
