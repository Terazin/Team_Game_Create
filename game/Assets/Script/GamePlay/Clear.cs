using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public int enemyNum; //�G�̐��iComponent����ݒ�\�j
    public int destroyCount;
    public string NextStage; //�����Ɏ��̃X�e�[�W��Scene��������B

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
