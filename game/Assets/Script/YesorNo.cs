using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI�R���|�[�l���g�̎g�p

public class YesorNo : MonoBehaviour
{
    Button Yes;
    Button No;

    void Start()
    {
        // �{�^���R���|�[�l���g�̎擾
        Yes = GameObject.Find("/Canvas/Yes1").GetComponent<Button>();
        No = GameObject.Find("/Canvas/No1").GetComponent<Button>();

        // �ŏ��ɑI����Ԃɂ������{�^���̐ݒ�
        Yes.Select();
    }
}