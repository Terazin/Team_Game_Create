using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    // ����̃V�[���̖��O
    public string[] targetSceneNames = { "Title", "MainMenuNew", "Stage_Select" };
    private static BGMManager instance;

    private void Awake()
    {
        // ���ɕʂ̃C���X�^���X�����݂���ꍇ�́A�����j������
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // �V�[�����؂�ւ���Ă��I�u�W�F�N�g���j������Ȃ��悤�ɂ���
        DontDestroyOnLoad(gameObject);
        instance = this;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ����̃V�[���ȊO�Ɉړ�������A���̃I�u�W�F�N�g��j��
        if (!IsTargetScene(scene.name))
        {
            Destroy(gameObject);
        }
    }

    // �V�[�����Ώۂ̃V�[�����ǂ����𔻒肷�郁�\�b�h
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
