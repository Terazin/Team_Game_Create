using UnityEngine;
using UnityEditor;

//[InitializeOnLoad]
//public static class PlayModeExitHandler
//{
//    static PlayModeExitHandler()
//    {
//        EditorApplication.playModeStateChanged += HandlePlayModeStateChange;
//    }

//    private static void HandlePlayModeStateChange(PlayModeStateChange state)
//    {
//        if (state == PlayModeStateChange.ExitingPlayMode)
//        {
//            // Play���[�h���I������Ƃ��Ɏ��s�����R�[�h
//            // PlayerPrefs�����Z�b�g����
//            PlayerPrefs.DeleteAll();

//            // �f�[�^�t�@�C�����폜����ꍇ�iPlayerProgress.json���폜�����j
//            string path = Application.persistentDataPath + "/playerProgress.json";
//            if (System.IO.File.Exists(path))
//            {
//                System.IO.File.Delete(path);
//            }
//        }
//    }
//}
