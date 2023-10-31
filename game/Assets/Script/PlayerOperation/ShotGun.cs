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
            // Rg[[ÌRT{^Å­Ë
            if (Input.GetAxis("TriggerRight") > 0.1f)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
=======

    private bool wasTriggerPressed = false; // ååã®ãã¬ã¼ã ã§RTãã¿ã³ãæ¼ããã¦ãããã®ãã©ã°

    void Update()
    {
        // ã³ã³ãã­ã¼ã©ã¼ã®RTãã¿ã³ã§ã®å¥åãåå¾
        bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;
>>>>>>> Stashed changes

        // ååã®ãã¬ã¼ã ã§ã¯æ¼ããã¦ããããç¾å¨ã®ãã¬ã¼ã ã§æ¼ããã¦ããå ´åã«å¼¾ãçºå°
        if (!wasTriggerPressed && isTriggerPressed)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletGun.transform.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
        }

        // ãã©ã°ã®æ´æ°
        wasTriggerPressed = isTriggerPressed;

        // ã­ã£ã©ã¯ã¿ã¼ã®yè»¸ã®åè»¢ãã«ã¡ã©ã®yè»¸ã®åè»¢ã«ä¸è´ããã
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
