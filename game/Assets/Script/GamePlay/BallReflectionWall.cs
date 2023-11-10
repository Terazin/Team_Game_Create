using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReflectionWall : MonoBehaviour
{
    [SerializeField] SceneReserch sceneReserch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Rigidbody rb = collision.rigidbody;
            if (rb != null)
            {
                ContactPoint contactPoint = collision.GetContact(0);
                rb.velocity = Vector3.Reflect(collision.relativeVelocity, contactPoint.normal);
                sceneReserch.bulletRefCount++;
            }

        }
    }
}
