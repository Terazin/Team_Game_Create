using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �^�O���w�肵�ăQ�[���I�u�W�F�N�g���擾
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        // �擾�����Q�[���I�u�W�F�N�g�ɑ΂��鑀������[�v�ōs��
        foreach (GameObject enemy in enemyObjects)
        {
            Debug.Log("Enemy�^�O���������I�u�W�F�N�g���F" + enemy.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
