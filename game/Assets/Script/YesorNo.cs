using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用

public class YesorNo : MonoBehaviour
{
    Button Yes;
    Button No;

    void Start()
    {
        // ボタンコンポーネントの取得
        Yes = GameObject.Find("/Canvas/Yes1").GetComponent<Button>();
        No = GameObject.Find("/Canvas/No1").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        Yes.Select();
    }
}