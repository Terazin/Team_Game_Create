using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWarp : MonoBehaviour
{
    private float speed = 3.0f;

    [SerializeField]
    private Transform warpTarget; // ワープ先の位置を指定するためのオブジェクト

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
        }
    }
}
