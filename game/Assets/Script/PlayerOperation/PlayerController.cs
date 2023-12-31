using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private float speed;
    private Vector3 movement;
    private CharacterController controller;

    // 方向転換用
    private Vector3 moveDir = Vector3.zero;
    private float gravity = 3f;

    // カメラの回転用
    //public float turnSpeed = 150f; // 追加: この数値を変更して、カメラの回転速度を調整できます。
    //private Transform camTransform;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        //camTransform = Camera.main.transform; // カメラのTransformを取得
        speed = walkSpeed;
    }

    void Update()
    {
        PlayerMove();
        //CameraTurn(); // 追加: カメラの回転処理を呼び出し

    }

    void PlayerMove()
    {
        float moveH = Input.GetAxis("Axis X");
        float moveV = Input.GetAxis("Axis Y");
        movement = new Vector3(moveH, 0, -moveV);

        Vector3 desiredMove = Camera.main.transform.forward * movement.z + Camera.main.transform.right * movement.x;
        moveDir.x = desiredMove.x * 3f;
        moveDir.z = desiredMove.z * 3f;
        moveDir.y -= gravity * Time.deltaTime;

        controller.Move(moveDir * Time.deltaTime * speed);
    }

    // 追加: カメラの回転を制御
    //void CameraTurn()
    //{
    //    float turnH = Input.GetAxis("RightStick Horizontal");

    //    camTransform.Rotate(Vector3.up * turnH * turnSpeed * Time.deltaTime); // 水平方向の回転
    //}



}