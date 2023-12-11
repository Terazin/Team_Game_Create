using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public GameObject bulletGun;
    public GameObject bulletPrefab;
    public GameObject bulletDel;
    //public AudioClip shotSound;
    //public CinemachineVirtualCamera virtualCamera;
    public float shotSpeed;
    //public Transform playerTransform;
    public float switchBackDelay = 5.0f;
    public AudioClip shotSound;

    AudioSource audioSource_;

    //private bool wasTriggerPressed = false;// 前回のフレームでRTボタンが押されていたかのフラグ
    //private Transform originalFollowTarget;
    public bool IsShot = false;

    void Start()
    {
        //originalFollowTarget = virtualCamera.Follow;
        audioSource_ = audioSource.GetComponent<AudioSource>();
    }
    void Update()
    {
        // コントローラーのRTボタンでの入力を取得
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;

        if (!IsShot)
        {
            // 前回のフレームでは押されておらず、現在のフレームで押されている場合に弾を発射
            if (isTriggerPressed)  
            {
                audioSource_.PlayOneShot(shotSound);
                //yield return new WaitForSeconds(0.3f);

                GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
                //animator.SetTrigger("GunFire");//銃の射撃アニメーション呼び出し
                bulletDel = bullet;
                //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
                //virtualCamera.Follow = bullet.transform;
                //StartCoroutine(SwitchBackToPlayerAfterDelay());
                IsShot = true;
                
            }
        }
    }

    //private IEnumerator Shot()
    //{
    //    yield return new WaitForSeconds(0.3f);

    //    GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
    //    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
    //    bulletRb.AddForce(transform.forward * shotSpeed);
    //    //animator.SetTrigger("GunFire");//銃の射撃アニメーション呼び出し
    //    bulletDel = bullet;
    //    //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
    //    //virtualCamera.Follow = bullet.transform;
    //    //StartCoroutine(SwitchBackToPlayerAfterDelay());
    //    IsShot = true;
    //}
}
