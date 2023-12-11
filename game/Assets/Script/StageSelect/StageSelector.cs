using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelector : MonoBehaviour
{
    public GameObject two;
    public GameObject therr;
    public GameObject four;
    public GameObject go;
    public GameObject roku;
    public GameObject nana;
    public GameObject hati;
    public GameObject Q;
    public GameObject zyuu;
   

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

        if (playerProgress.stageNum >= 4)
        {
            go.SetActive(true);
        }

        if (playerProgress.stageNum >= 5)
        {
            roku.SetActive(true);
        }

        if (playerProgress.stageNum >= 6)
        {
            nana.SetActive(true);
        }

        if (playerProgress.stageNum >= 7)
        {
            hati.SetActive(true);
        }

        if (playerProgress.stageNum >= 8)
        {
            Q.SetActive(true);
        }

        if (playerProgress.stageNum >= 10)
        {
            zyuu.SetActive(true);
        }

    }

    private void UpdateStageUI()
    {
       
    }
    public void ClearNextStage()
    {
        playerProgress.stageNum++; // 次のステージをクリアしたので stageNum を増やす
        SaveSystem.SavePlayerProgress(playerProgress); // 進行状況を保存

    }

}
