using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpL : MonoBehaviour
{
    [SerializeField] private Transform warpPoint;
    [SerializeField] private float forceMagnitude = 10.0f; // �͂̑傫��

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Rigidbody rb = collision.rigidbody;

            // ���[�v�|�C���g�̈ʒu�ɒe�����[�v
            collision.transform.position = warpPoint.position;

            // ���[�v��ɉE�����ɗ͂�������
            Vector3 forceDirection = Vector3.left;
            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }
}
