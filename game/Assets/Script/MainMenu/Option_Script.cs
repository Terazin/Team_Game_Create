using Unity.VisualScripting;
using UnityEngine;

public class Option_Script : MonoBehaviour
{
   /* public CinemachineFreeLook cinemachineFreeLook;
    public Sidebar cameraSliderX;
    public Sidebar cameraSliderY;*/


    public void OnClick_960x540()
    {
        Screen.SetResolution(960, 540, FullScreenMode.Windowed, 60);
    }

    public void OnClick_1920x1080()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed, 60);
    }

   /* public void OnMouseSetting()
    {
        cameraSpeedX = ca
    }*/

}