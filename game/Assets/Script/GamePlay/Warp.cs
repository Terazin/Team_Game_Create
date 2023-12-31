using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
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

            // ワープ後に特定の面から弾を発射
            Vector3 shootDirection = warpPoint.TransformDirection(Vector3.up); // ローカル座標系の上方向をワールド座標系に変換
            rb.AddForce(shootDirection * forceMagnitude, ForceMode.Impulse);
        }
    }
}
