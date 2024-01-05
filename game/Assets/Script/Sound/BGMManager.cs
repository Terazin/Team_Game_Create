using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    // 特定のシーンの名前
    public string[] targetSceneNames = { "Title", "MainMenuNew", "Stage_Select" };
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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 特定のシーン以外に移動したら、このオブジェクトを破棄
        if (!IsTargetScene(scene.name))
        {
            Destroy(gameObject);
        }
    }

    // シーンが対象のシーンかどうかを判定するメソッド
    private bool IsTargetScene(string sceneName)
    {
        foreach (string targetScene in targetSceneNames)
        {
            if (sceneName == targetScene)
            {
                return true;
            }
        }
        return false;
    }
}
