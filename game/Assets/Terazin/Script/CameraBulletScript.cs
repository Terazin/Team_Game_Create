using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraBulletScript : MonoBehaviour
{
    //public GameObject Bullet; // �e�ۂ̃v���n�u�ւ̎Q��
    //public Camera mainCamera; // ���C���J�����ւ̎Q��
    //public Camera bulletCamera; // �e�ۃJ�����ւ̎Q��
    //public float bulletSpeed = 100f; // �e�ۂ̑��x
    //public float timeToReturnToMainCamera = 5f;

    //private GameObject currentBullet; // ���݂̒e�ۃI�u�W�F�N�g
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
    //    // �e�ۂ𐶐����Ĕ��˂���
    //    GameObject bullet = Instantiate(Bullet, mainCamera.transform.position, mainCamera.transform.rotation);
    //    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    //    rb.velocity = mainCamera.transform.forward * bulletSpeed;

    //    // �e�ۂɃA�^�b�`���ꂽ�J�������擾
    //    bulletCamera = bullet.GetComponentInChildren<Camera>();
    //    SwitchCameraTo(bulletCamera);

    //    // ��莞�Ԍ�Ƀ��C���J�����ɖ߂�
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
