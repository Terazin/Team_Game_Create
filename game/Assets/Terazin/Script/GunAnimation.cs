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
        // コントローラーのRTボタンでの入力を取得
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;

        if (!IsShot)
        {
            // 前回のフレームでは押されておらず、現在のフレームで押されている場合に弾を発射
            if (isTriggerPressed)
            {
                animator.SetBool("GunFire", true);
            }
        }


        //フラグの更新
        //wasTriggerPressed = isTriggerPressed;
    }
}
