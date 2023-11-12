using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LockOn : MonoBehaviour
{
    private float lockRange = 250; // ���R�ɐݒ�
    public Image aimImage;
    private Color originalColor;

    void Start()
    {
        // �J�[�\�����\���ɂ���B(�R���g���[����UI�I�����o����悤�ɂȂ�����A16�s�ڂ̃R�[�h�̃R�����g���O���B)
        //Cursor.lockState = CursorLockMode.Locked;

        originalColor = aimImage.color;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * 30, Color.red, 30f);

        if (Physics.Raycast(ray, out hit, lockRange)) 
        {
            GameObject target = hit.collider.gameObject;

            if (target.CompareTag("Enemy"))
            {
                // �ԐF�ɕύX
                aimImage.color = Color.red;
            }
            else
            {
                aimImage.color = originalColor;
            }
        }
    }
}
