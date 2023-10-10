using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private float speed;
    private Vector3 movement;
    private CharacterController controller;
   

    // ���ǉ��i�����]���j
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

        // ���ǉ��i�����]���j
        Vector3 desiredMove = Camera.main.transform.forward * movement.z + Camera.main.transform.right * movement.x;
        moveDir.x = desiredMove.x * 3f;
        moveDir.z = desiredMove.z * 3f;
        moveDir.y -= gravity * Time.deltaTime; // �^���d�͂̎���

        // �����ǁi�����]���j
        controller.Move(moveDir * Time.deltaTime * speed);       
    }

    
}