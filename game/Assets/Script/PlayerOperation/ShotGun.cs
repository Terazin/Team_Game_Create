using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    private Animator animator;
    public GameObject bulletGun;
    public GameObject bulletPrefab;
    public GameObject bulletDel;
    //public AudioClip shotSound;
    public CinemachineVirtualCamera virtualCamera;
    public float shotSpeed;
    public Transform playerTransform;
    public float switchBackDelay = 5.0f;

    private bool wasTriggerPressed = false;// 前回のフレームでRTボタンが押されていたかのフラグ
    private Transform originalFollowTarget;

    void Start()
    {
        originalFollowTarget = virtualCamera.Follow;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // コントローラーのRTボタンでの入力を取得
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;

        // 前回のフレームでは押されておらず、現在のフレームで押されている場合に弾を発射
        if (!wasTriggerPressed && isTriggerPressed)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);
            //animator.SetTrigger("GunFire");//銃の射撃アニメーション呼び出し

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
            virtualCamera.Follow = bullet.transform;
            StartCoroutine(SwitchBackToPlayerAfterDelay());
        }

        //フラグの更新
        wasTriggerPressed = isTriggerPressed;
    }

    private IEnumerator SwitchBackToPlayerAfterDelay()
    {
        yield return new WaitForSeconds(switchBackDelay);
        // キャラクターのy軸の回転をカメラのy軸の回転に一致させる
        Vector3 newRotation = new Vector3(transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, transform.eulerAngles.z);
        transform.eulerAngles = newRotation;
        Debug.Log("Switching back to player.");

    // デバッグログを出力して、カメラがプレイヤーに戻ったかを確認
    if (virtualCamera.Follow == originalFollowTarget)
    {
        Debug.Log("Camera has switched back to the player.");
    }
    else
    {
        Debug.Log("Camera did not switch back to the player.");
    }

        // カメラのFollowをプレイヤーに戻す
        virtualCamera.Follow = originalFollowTarget;
    }
}
