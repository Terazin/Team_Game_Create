using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameObject GameOverWindow;
    private float lockRange = 200;
    private bool m_IsPlayerInRange;
    private bool isCooldown = false; // ���m�̃N�[���_�E�����
    private int detectionCount = 0; // �v���C���[�����m���ꂽ��
    private int maxDetectionCount = 3; // �Q�[���I�[�o�[�ɂȂ錟�m�̍ő��
    private float cooldownDuration =2.0f; // ���̌��m�܂ł̃N�[���_�E������

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {
        if (m_IsPlayerInRange && !isCooldown)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit, lockRange))
            {
                if (raycastHit.collider.transform == player)
                {
                    detectionCount++; // �v���C���[�����m���ꂽ�񐔂𑝂₷
                    Debug.Log("����������");
                    if (detectionCount >= maxDetectionCount)
                    {
                        GameOverWindow.SetActive(true);
                        SetGamePaused(true); // �Q�[���̎��Ԃ��~
                        PlayerPrefs.SetInt("IsGamePaused", 1);
                    }

                    StartCooldown(); // �N�[���_�E�����J�n
                }
            }
        }

        if (isCooldown)
        {
            cooldownDuration -= Time.deltaTime;
            if (cooldownDuration <= 0)
            {
                isCooldown = false;
                cooldownDuration = 5.0f; // �N�[���_�E�����Ԃ����Z�b�g
            }
        }
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    void StartCooldown()
    {
        isCooldown = true;
    }
}
