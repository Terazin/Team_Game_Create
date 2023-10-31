using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public GameObject bulletGun;
    public GameObject bulletPrefab;
    //public AudioClip shotSound;
    public float shotSpeed;
<<<<<<< Updated upstream
    private bool shotBullet = false;

    void Update()
    {
        if (!shotBullet)
        {
            // �R���g���[���[��RT�{�^���Ŕ���
            if (Input.GetAxis("TriggerRight") > 0.1f)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
=======

    private bool wasTriggerPressed = false; // 前回のフレームでRTボタンが押されていたかのフラグ

    void Update()
    {
        // コントローラーのRTボタンでの入力を取得
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;
>>>>>>> Stashed changes

        // 前回のフレームでは押されておらず、現在のフレームで押されている場合に弾を発射
        if (!wasTriggerPressed && isTriggerPressed)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
        }

        // フラグの更新
        wasTriggerPressed = isTriggerPressed;

        // キャラクターのy軸の回転をカメラのy軸の回転に一致させる
        Vector3 newRotation = new Vector3(transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, transform.eulerAngles.z);
        transform.eulerAngles = newRotation;

<<<<<<< Updated upstream
                shotBullet = true;
            }
        }
=======
>>>>>>> Stashed changes
    }
}
