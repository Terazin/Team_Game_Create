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
        // �J�E���g�_�E���^�C���𐮌`���ĕ\��
        CountDown.text = String.Format("{0:00.00}", CountDownTime);
        // �o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;

        float timer = CountTime - Time.time;
        uiFill.fillAmount = Mathf.InverseLerp(0, CountTime, timer);
        uiText.text = String.Format("{0:00.00}", CountDownTime);

        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j

        if (CountDownTime <= 0.0F)
            {
                CountDownTime = 0.0F;
            timeover.SetActive(true);
        }

        
    }
}
