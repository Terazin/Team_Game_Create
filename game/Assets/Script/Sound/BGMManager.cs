using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
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
    }

    private void Start()
    {
        // ������BGM�Đ��̏������Ȃǂ�ǉ�
    }

    // ���̃X�N���v�g����Ăяo����郁�\�b�h�Ȃǂ�ǉ�
}
