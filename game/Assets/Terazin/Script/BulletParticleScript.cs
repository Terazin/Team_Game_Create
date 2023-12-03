using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleScript : MonoBehaviour
{
    public ParticleSystem BulletParticle;
    private Vector3 lastDirection;
    // Start is called before the first frame update
    void Start()
    {
        // ����������ۑ�
        lastDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentDirection = transform.forward;

        // �������ς�������ǂ������`�F�b�N
        if (currentDirection != lastDirection)
        {
            // �p�[�e�B�N���V�X�e���̕������X�V
            var shape = BulletParticle.shape;
            shape.rotation = Quaternion.LookRotation(currentDirection).eulerAngles;

            // �Ō�̕������X�V
            lastDirection = currentDirection;
        }
    }
}
