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

    private float CountDownTime; //�c�莞��
    public GameObject timeover;

    private float CountTime; //���萧������(60�b)

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 60.0F;
        CountTime = 60.0f;
        uiFill.fillAmount = 1f; //ring�̃Q�[�W���AFilled��fillAmount�Ő���
        timeover.SetActive(false);
    }
    
   
    // Update is called once per frame
    void Update()
    {
        // �J�E���g�_�E���^�C���𐮌`���ĕ\��
        CountDown.text = String.Format("{0:00.00}", CountDownTime);
        // �o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;

        uiFill.fillAmount = Mathf.InverseLerp(0, CountTime, CountDownTime);
        uiText.text = String.Format("{0:00.00}", CountDownTime);

        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j

        if (CountDownTime <= 0.0F)
            {
                CountDownTime = 0.0F;
            timeover.SetActive(true);
        }

        
    }
}
