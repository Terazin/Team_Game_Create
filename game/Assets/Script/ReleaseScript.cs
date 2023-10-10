using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReleaseScript : MonoBehaviour
{
    private StageSelector stageSelector;
    private void Start()
    {
        stageSelector = FindObjectOfType<StageSelector>();
    }

    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            // ClearNextStage() ���\�b�h���Ăяo���Ď��̃X�e�[�W��ݒ�
            stageSelector.ClearNextStage();
        }
    }
}

