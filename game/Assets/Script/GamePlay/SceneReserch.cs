using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReserch : MonoBehaviour
{
    string sceneName;
    int bulletCount;
    int bulletRefLimit;

    void Setting(string name)
    {
        switch (name)
        {
            case "FirstStage":
                bulletRefLimit = 6;
                break;
            case "SecondStage":
                bulletRefLimit = 3;
                break;
            case "ThirdStage":
                bulletRefLimit = 2;
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
        if (bulletRefLimit == bulletCount)
        {
            Destroy(gameObject);
            bulletRefLimit = 0;
        }

    }

    public void OnCollisionExit(Collision collision)
    {
        bulletCount++;
    }


}
