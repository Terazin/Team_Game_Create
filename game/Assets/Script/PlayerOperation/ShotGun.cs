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
    public CinemachineVirtualCamera virtualCamera; // Virtual Cameraをインスペクタから設定する
    public Transform playerTransform; // PlayerのTransformをインスペクタから設定する
    public float switchBackDelay = 5.0f; // カメラがプレイヤーに戻るまでの時間

    private Transform originalFollowTarget;

    void Start()
    {
        // カメラの元のFollowターゲットを保持
        originalFollowTarget = virtualCamera.Follow;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);

            // カメラのFollowを弾に変更
            virtualCamera.Follow = bullet.transform;

            // 弾にカメラをフォーカスした後、一定時間でカメラをプレイヤーに戻す
            StartCoroutine(SwitchBackToPlayerAfterDelay());
        }
    }


    private IEnumerator SwitchBackToPlayerAfterDelay()
    {
        yield return new WaitForSeconds(switchBackDelay);

        // カメラのFollowをプレイヤーに戻す
        virtualCamera.Follow = originalFollowTarget;
    }
}