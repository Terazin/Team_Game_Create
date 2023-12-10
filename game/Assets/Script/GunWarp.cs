using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWarp : MonoBehaviour
{
    private float speed = 3.0f;

    [SerializeField]
    private Transform warpTarget; // ワープ先の位置を指定するためのオブジェクト

    private Rigidbody rb;

    void Start()
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "WarpPoint" && warpTarget != null)
        {
            // ワープ先の位置にワープ
            this.transform.position = warpTarget.position;

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
