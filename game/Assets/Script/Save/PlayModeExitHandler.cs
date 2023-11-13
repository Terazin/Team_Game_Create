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
//            // Playモードが終了するときに実行されるコード
//            // PlayerPrefsをリセットする
//            PlayerPrefs.DeleteAll();

//            // データファイルを削除する場合（PlayerProgress.jsonを削除する例）
//            string path = Application.persistentDataPath + "/playerProgress.json";
//            if (System.IO.File.Exists(path))
//            {
//                System.IO.File.Delete(path);
//            }
//        }
//    }
//}
