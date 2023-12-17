using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using TMPro;
public class TimeOver : MonoBehaviour
{
   
    [SerializeField] private Image uiFill;
    [SerializeField] private TextMeshProUGUI uiText;
    [SerializeField] TextMeshProUGUI CountDown;

    private float CountDownTime; //残り時間
    public GameObject timeover;

    private float CountTime; //既定制限時間(60秒)

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 60.0F;
        CountTime = 60.0f;
        uiFill.fillAmount = 1f; //ringのゲージを、FilledのfillAmountで制御
        timeover.SetActive(false);
    }
    
   
    // Update is called once per frame
    void Update()
    {
        // カウントダウンタイムを整形して表示
        CountDown.text = String.Format("{0:00.00}", CountDownTime);
        // 経過時刻を引いていく
        CountDownTime -= Time.deltaTime;

        uiFill.fillAmount = Mathf.InverseLerp(0, CountTime, CountDownTime);
        uiText.text = String.Format("{0:00.00}", CountDownTime);

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）

        if (CountDownTime <= 0.0F)
            {
                CountDownTime = 0.0F;
            timeover.SetActive(true);
        }

        
    }
}
