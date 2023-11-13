using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // 特定のシーン名
    public string targetSceneName = "FirstStage";

    private void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += OnSceneLoaded; // シーンがロードされた時のイベントにメソッドを追加
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 特定のシーンに移動したら、このオブジェクトを破棄
        if (scene.name == targetSceneName)
        {
            Destroy(gameObject);
        }
    }
}
