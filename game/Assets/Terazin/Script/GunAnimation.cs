using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    private Animator animator;
    public bool IsShot = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �R���g���[���[��RT�{�^���ł̓��͂��擾
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;

        if (!IsShot)
        {
            // �O��̃t���[���ł͉�����Ă��炸�A���݂̃t���[���ŉ�����Ă���ꍇ�ɒe�𔭎�
            if (isTriggerPressed)
            {
                animator.SetBool("GunFire", true);
            }
        }


        //�t���O�̍X�V
        //wasTriggerPressed = isTriggerPressed;
    }
}
