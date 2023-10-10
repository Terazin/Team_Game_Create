using UnityEngine;
using System.Collections;

public class End : MonoBehaviour
{

    // ダイアログのキャンバス
    [SerializeField]
    Canvas canvas;

    void Start()
    {
        canvas.enabled = false;
    }

    public void OnApplicationQuit()
    {
        // ダイアログが開いていなければ終了処理はキャンセル
        if (canvas.enabled == false)
            Application.CancelQuit();

        // ダイアログの表示
        canvas.enabled = true;
    }


    //  終了ボタン

    public void OnCallExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    // キャンセルボタン

    public void OnCallCancel()
    {
        canvas.enabled = false;
    }
}