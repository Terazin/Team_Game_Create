using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWarp : MonoBehaviour
{
    private float speed = 3.0f;

    [SerializeField]
    private Transform warpTarget; // ���[�v��̈ʒu���w�肷�邽�߂̃I�u�W�F�N�g

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
            // ���[�v��̈ʒu�Ƀ��[�v
            this.transform.position = warpTarget.position;
        }
    }
}
