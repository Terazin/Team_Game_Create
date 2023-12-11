using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWarp : MonoBehaviour
{
    private Transform warpTarget;
    private Rigidbody rb;
    private float speed = 3.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            // Rigidbodyがアタッチされていない場合は、コンポーネントを追加
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = new Vector3(
            transform.position.x + moveX, transform.position.y, transform.position.z + moveZ
        );
    }

    public void SetTarget(Transform warpTarget)
    {
        this.warpTarget = warpTarget;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "WarpPoint")
        {
            // ワープ先の位置にワープ
            transform.position = warpTarget.position;

            // 吹っ飛ばしの力を追加
            if (rb != null)
            {
                // 吹っ飛ばす方向を指定（例：上方向に力を加える）
                Vector3 forceDirection = Vector3.right;

                // 吹っ飛ばす力を調整
                float forceMagnitude = 10.0f;

                // 力を加える
                rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
            }
        }
    }
}
