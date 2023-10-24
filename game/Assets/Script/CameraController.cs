using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // 回転の速度

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        // 入力軸から回転を取得
        float horizontalRotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // カメラをY軸を中心に回転させる（左右回転）
        transform.Rotate(0, horizontalRotation, 0);

        // カメラの上下の向きを変える（注意: カメラのローカル軸に対して回転を行う）
        transform.Rotate(-verticalRotation, 0, 0);
    }
}
