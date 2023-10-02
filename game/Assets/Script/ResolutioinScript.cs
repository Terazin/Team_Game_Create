using UnityEngine;

public class ResolutioinScript : MonoBehaviour
{
    public void OnClick_960x540()
    {
        Screen.SetResolution(960, 540, FullScreenMode.Windowed, 60);
    }

    public void OnClick_1920x1080()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed, 60);
    }
}