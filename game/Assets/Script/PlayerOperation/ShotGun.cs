using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public GameObject bulletGun;
    public GameObject bulletPrefab;
    //public AudioClip shotSound;
    public float shotSpeed;
    //private bool shotBullet = false;
    public CinemachineVirtualCamera virtualCamera; // Virtual Cameraをインスペクタから設定する
    public Transform playerTransform; // PlayerのTransformをインスペクタから設定する
    public float switchBackDelay = 2.0f; // カメラがプレイヤーに戻るまでの時間

    private Transform originalFollowTarget;

    void Start()
    {
        // カメラの元のFollowターゲットを保持
        originalFollowTarget = virtualCamera.Follow;
        if (virtualCamera.LookAt == null)
        {
            virtualCamera.LookAt = playerTransform; // プレイヤーのTransformをLookAtターゲットとして設定
        }
    }

    void Update()
    {
        //if (!shotBullet)  //弾を一発撃つと、shotBulletがtrueになって撃てなくなる。
        //{
        // マウス左クリックで発射
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);

            //shotBullet = true;

            // カメラのFollowを弾に変更
            virtualCamera.Follow = bullet.transform;

            // 弾にカメラをフォーカスした後、一定時間でカメラをプレイヤーに戻す
            StartCoroutine(SwitchBackToPlayerAfterDelay());
        }
        //}
    }

    private IEnumerator SwitchBackToPlayerAfterDelay()
    {
        yield return new WaitForSeconds(switchBackDelay);

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
