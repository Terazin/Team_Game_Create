using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelector : MonoBehaviour
{
   


    public GameObject two;
    public GameObject therr;
    public GameObject four;

    private PlayerProgress playerProgress;

    void Start()
    {
        playerProgress = SaveSystem.LoadPlayerProgress();
        UpdateStageUI();
    }

    void Update()
    {
        if (playerProgress.stageNum >= 1)
        {
            two.SetActive(true);
        }

        if (playerProgress.stageNum >= 2)
        {
            therr.SetActive(true);
        }

        if (playerProgress.stageNum >= 3)
        {
            four.SetActive(true);
        }
    }

    private void UpdateStageUI()
    {
       
    }
    public void ClearNextStage()
    {
        playerProgress.stageNum++; // ���̃X�e�[�W���N���A�����̂� stageNum �𑝂₷
        SaveSystem.SavePlayerProgress(playerProgress); // �i�s�󋵂�ۑ�

    }

}
