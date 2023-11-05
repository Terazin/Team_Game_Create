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

        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);

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
