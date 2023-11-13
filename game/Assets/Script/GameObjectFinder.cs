using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // タグを指定してゲームオブジェクトを取得
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        // 取得したゲームオブジェクトに対する操作をループで行う
        foreach (GameObject enemy in enemyObjects)
        {
            Debug.Log("Enemyタグを持ったオブジェクト名：" + enemy.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
