using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform camTransform;
    public float walkSpeed;
    private float speed;
    private Vector3 movement;
    private CharacterController controller;

    // 方向転換用
    private Vector3 moveDir = Vector3.zero;
    private float gravity = 3f;

    // カメラの回転用
    public float turnSpeed = 150f; // 追加: この数値を変更して、カメラの回転速度を調整できます。

    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = walkSpeed;
    }

    void Update()
    {
        PlayerMove();
        CameraTurn(); // 追加: カメラの回転処理を呼び出し
    }

    void PlayerMove()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        movement = new Vector3(moveH, 0, moveV);

        Vector3 desiredMove = camTransform.forward * movement.z + camTransform.right * movement.x;
        moveDir.x = desiredMove.x * 3f;
        moveDir.z = desiredMove.z * 3f;
        moveDir.y -= gravity * Time.deltaTime;

        controller.Move(moveDir * Time.deltaTime * speed);
    }

    // 追加: カメラの回転を制御
    void CameraTurn()
    {
        float turnH = Input.GetAxis("RightStick Horizontal");
        float turnV = Input.GetAxis("RightStick Vertical");

        Debug.Log(turnH);


        camTransform.Rotate(Vector3.up * turnH * turnSpeed * Time.deltaTime); // 水平方向の回転
        camTransform.Rotate(Vector3.right * -turnV * turnSpeed * Time.deltaTime); // 垂直方向の回転（マイナスを使って上下の動きを反転）
    }
}
