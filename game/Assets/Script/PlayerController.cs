using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �i�|�C���g�j
// ���̂Q�s�̃R�[�h�ŃR���|�[�l���g�������I�ɒǉ�����܂��B
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private Vector3 movement;
    private CharacterController characterController;
    private AudioSource audioSource;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        movement = new Vector3(moveH, 0, moveV);

        characterController.Move(movement * Time.deltaTime * walkSpeed);
    }
}