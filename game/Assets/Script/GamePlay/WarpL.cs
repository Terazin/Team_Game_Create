using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpL : MonoBehaviour
{
    [SerializeField] private Transform warpPoint;
    [SerializeField] private float forceMagnitude = 10.0f; // 力の大きさ

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Rigidbody rb = collision.rigidbody;

            // ワープポイントの位置に弾をワープ
            collision.transform.position = warpPoint.position;

            // ワープ後に右方向に力を加える
            Vector3 forceDirection = Vector3.left;
            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }
}
