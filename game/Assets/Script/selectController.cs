using UnityEngine;

public class selectController : MonoBehaviour
{
    public bool isStickInputDisabled = false;

    void Update()
    {
        if (isStickInputDisabled)
        {
            // スティック入力を無視する
            return;
        }

        // 通常はここでスティック入力を処理する
        float horizontal = Input.GetAxis("Axis X");
        float vertical = Input.GetAxis("Axis Y");

        // スティックの入力に基づいて何かをする
        MovePlayer(horizontal, vertical);
    }

    void MovePlayer(float horizontal, float vertical)
    {
        // プレイヤーの移動など、入力に応じた処理
        // 例: transform.Translate(horizontal, 0, vertical);
    }
}
