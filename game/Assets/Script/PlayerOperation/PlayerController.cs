using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private float speed;
    private Vector3 movement;
    private CharacterController controller;
   

    // ★追加（方向転換）
    private Vector3 moveDir = Vector3.zero;
    private float gravity = 3f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        speed = walkSpeed;
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        movement = new Vector3(moveH, 0, moveV);

        // ★追加（方向転換）
        Vector3 desiredMove = Camera.main.transform.forward * movement.z + Camera.main.transform.right * movement.x;
        moveDir.x = desiredMove.x * 3f;
        moveDir.z = desiredMove.z * 3f;
        moveDir.y -= gravity * Time.deltaTime; // 疑似重力の実装

        // ★改良（方向転換）
        controller.Move(moveDir * Time.deltaTime * speed);       
    }

    
}