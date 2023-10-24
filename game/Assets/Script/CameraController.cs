using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // ��]�̑��x

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        // ���͎������]���擾
        float horizontalRotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // �J������Y���𒆐S�ɉ�]������i���E��]�j
        transform.Rotate(0, horizontalRotation, 0);

        // �J�����̏㉺�̌�����ς���i����: �J�����̃��[�J�����ɑ΂��ĉ�]���s���j
        transform.Rotate(-verticalRotation, 0, 0);
    }
}
