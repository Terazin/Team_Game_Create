using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class TimeOver : MonoBehaviour
{
   
    [SerializeField] private Image uiFill;
    [SerializeField] private TextMeshProUGUI uiText;
    [SerializeField] private float CountTime;
    [SerializeField] TextMeshProUGUI CountDown;
    public  float CountDownTime;
    public GameObject timeover;
  
    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 60.0F;
        timeover.SetActive(false);
    }
    
   
    // Update is called once per frame
    void Update()
    {
        // カウントダウンタイムを整形して表示
        CountDown.text = String.Format("{0:00.00}", CountDownTime);
        // 経過時刻を引いていく
        CountDownTime -= Time.deltaTime;

        float timer = CountTime - Time.time;
        uiFill.fillAmount = Mathf.InverseLerp(0, CountTime, timer);
        uiText.text = String.Format("{0:00.00}", CountDownTime);

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）

        if (CountDownTime <= 0.0F)
            {
                CountDownTime = 0.0F;
            timeover.SetActive(true);
        }

        
    }
}
