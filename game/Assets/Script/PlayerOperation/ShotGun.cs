using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    public GameObject bulletGun;
    public GameObject bulletPrefab;
    //public AudioClip shotSound;
    public float shotSpeed;
    private bool shotBullet = false;

    void Update()
    {
        //if (!shotBullet)  //�e���ꔭ���ƁAshotBullet��true�ɂȂ��Č��ĂȂ��Ȃ�B
        //{
            // �}�E�X���N���b�N�Ŕ���
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);

                shotBullet = true;
            }
        //}
    }
}
