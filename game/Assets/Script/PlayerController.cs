using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 2.0f;
    public float yRotationLimit = 80.0f;

    private float xRotation = 0.0f;
    private Camera playerCamera; // �v���C���[�̃J�������Q�Ƃ��邽�߂̕ϐ�

    void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        // �J�[�\������ʂ̒����Ƀ��b�N���A��\���ɂ���
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();
        RotateView();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        transform.Translate(move * speed * Time.deltaTime);
    }

    void RotateView()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // �J������X���̉�]
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -yRotationLimit, yRotationLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // �v���C���[��Y���̉�]
        transform.Rotate(Vector3.up * mouseX);
    }
}
