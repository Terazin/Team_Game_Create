using UnityEngine;
using System.Collections;

public class End : MonoBehaviour
{

    // �_�C�A���O�̃L�����o�X
    [SerializeField]
    Canvas canvas;

    void Start()
    {
        canvas.enabled = false;
    }

    public void OnApplicationQuit()
    {
        // �_�C�A���O���J���Ă��Ȃ���ΏI�������̓L�����Z��
        if (canvas.enabled == false)
            Application.CancelQuit();

        // �_�C�A���O�̕\��
        canvas.enabled = true;
    }


    //  �I���{�^��

    public void OnCallExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    // �L�����Z���{�^��

    public void OnCallCancel()
    {
        canvas.enabled = false;
    }
}