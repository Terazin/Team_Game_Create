using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun_Test : MonoBehaviour
{
    public GameObject laserGun;
    public GameObject beamPrefab;
    //public AudioClip shotSound;
    public float shotSpeed;
    bool shotGun = false;

    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            shotGun = false;
        }

        if (!shotGun)
        {
            // マウス左クリックで発射
            if (Input.GetAxis("TriggerRight") < 0f)
            {
                GameObject beam = Instantiate(beamPrefab, transform.position, laserGun.transform.rotation);
                Rigidbody beamRb = beam.GetComponent<Rigidbody>();
                beamRb.AddForce(transform.forward * shotSpeed);

                shotGun = true;

                //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
            }
        }

        
    }
}
