using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    private static BGMManager instance;

    private void Awake()
    {
        // 既に別のインスタンスが存在する場合は、これを破棄する
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // シーンが切り替わってもオブジェクトが破棄されないようにする
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    private void Start()
    {
        // ここにBGM再生の初期化などを追加
    }

    // 他のスクリプトから呼び出されるメソッドなどを追加
}
