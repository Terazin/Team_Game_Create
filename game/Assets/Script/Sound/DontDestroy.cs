using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // ����̃V�[����
    public string targetSceneName = "FirstStage";

    private void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += OnSceneLoaded; // �V�[�������[�h���ꂽ���̃C�x���g�Ƀ��\�b�h��ǉ�
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ����̃V�[���Ɉړ�������A���̃I�u�W�F�N�g��j��
        if (scene.name == targetSceneName)
        {
            Destroy(gameObject);
        }
    }
}
