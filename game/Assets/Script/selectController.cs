using UnityEngine;

public class selectController : MonoBehaviour
{
    public bool isStickInputDisabled = false;

    void Update()
    {
        if (isStickInputDisabled)
        {
            // �X�e�B�b�N���͂𖳎�����
            return;
        }

        // �ʏ�͂����ŃX�e�B�b�N���͂���������
        float horizontal = Input.GetAxis("Axis X");
        float vertical = Input.GetAxis("Axis Y");

        // �X�e�B�b�N�̓��͂Ɋ�Â��ĉ���������
        MovePlayer(horizontal, vertical);
    }

    void MovePlayer(float horizontal, float vertical)
    {
        // �v���C���[�̈ړ��ȂǁA���͂ɉ���������
        // ��: transform.Translate(horizontal, 0, vertical);
    }
}
