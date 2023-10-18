using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private float speed;
    private Vector3 movement;
    private CharacterController controller;

    // �����]���p
    private Vector3 moveDir = Vector3.zero;
    private float gravity = 3f;

    // �J�����̉�]�p
    public float turnSpeed = 150f; // �ǉ�: ���̐��l��ύX���āA�J�����̉�]���x�𒲐��ł��܂��B
    private Transform camTransform;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        camTransform = Camera.main.transform; // �J������Transform���擾
        speed = walkSpeed;
    }

    void Update()
    {
        PlayerMove();
        CameraTurn(); // �ǉ�: �J�����̉�]�������Ăяo��
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

    // �ǉ�: �J�����̉�]�𐧌�
    void CameraTurn()
    {
        float turnH = Input.GetAxis("RightStick Horizontal");
        float turnV = Input.GetAxis("RightStick Vertical");



        camTransform.Rotate(Vector3.up * turnH * turnSpeed * Time.deltaTime); // ���������̉�]
        camTransform.Rotate(Vector3.right * -turnV * turnSpeed * Time.deltaTime); // ���������̉�]�i�}�C�i�X���g���ď㉺�̓����𔽓]�j
    }
}