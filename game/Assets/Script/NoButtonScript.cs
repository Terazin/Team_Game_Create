using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�ǋL���Ă�����

public class NoButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Retry()//�����ɏ����������uRetry�v���I����ʂŕ\�������
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}