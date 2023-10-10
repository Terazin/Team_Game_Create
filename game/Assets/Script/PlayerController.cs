using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 2.0f;
    public float yRotationLimit = 80.0f;

    private float xRotation = 0.0f;
    private Camera playerCamera; // プレイヤーのカメラを参照するための変数

    void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        // カーソルを画面の中央にロックし、非表示にする
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

        // カメラのX軸の回転
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -yRotationLimit, yRotationLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // プレイヤーのY軸の回転
        transform.Rotate(Vector3.up * mouseX);
    }
}
