using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraBulletScript : MonoBehaviour
{
    //public GameObject Bullet; // 弾丸のプレハブへの参照
    //public Camera mainCamera; // メインカメラへの参照
    //public Camera bulletCamera; // 弾丸カメラへの参照
    //public float bulletSpeed = 100f; // 弾丸の速度
    //public float timeToReturnToMainCamera = 5f;

    //private GameObject currentBullet; // 現在の弾丸オブジェクト
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        FireBullet();
    //    }
    //}
    //void FireBullet()
    //{
    //    // 弾丸を生成して発射する
    //    GameObject bullet = Instantiate(Bullet, mainCamera.transform.position, mainCamera.transform.rotation);
    //    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    //    rb.velocity = mainCamera.transform.forward * bulletSpeed;

    //    // 弾丸にアタッチされたカメラを取得
    //    bulletCamera = bullet.GetComponentInChildren<Camera>();
    //    SwitchCameraTo(bulletCamera);

    //    // 一定時間後にメインカメラに戻す
    //    StartCoroutine(ReturnToMainCameraAfterTime(timeToReturnToMainCamera));
    //}

    //void SwitchCameraTo(Camera newCamera)
    //{
    //    mainCamera.enabled = false;
    //    newCamera.enabled = true;
    //}

    //IEnumerator ReturnToMainCameraAfterTime(float time)
    //{
    //    yield return new WaitForSeconds(time);

    //    if (bulletCamera != null)
    //    {
    //        bulletCamera.enabled = false;
    //    }
    //    mainCamera.enabled = true;
    //}
}
