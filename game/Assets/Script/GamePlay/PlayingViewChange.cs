using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayingViewChange : MonoBehaviour
{
    [SerializeField] ShotGun shotGun;
    [SerializeField] SceneReserch sceneReserch;
    [SerializeField] GameObject Player;
    [SerializeField] Clear Clear;

    public CinemachineVirtualCameraBase PlayerCamera;
    public CinemachineVirtualCameraBase UpCamera;
    public CinemachineVirtualCameraBase FinishedCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (shotGun.IsShot)
        {
            if (sceneReserch.IsBulletDelete)
            {
                Player.SetActive(true);
                PlayerCamera.Priority = 1;
                UpCamera.Priority = 0;
            }
            else
            {
                PlayerCamera.Priority = 0;
                UpCamera.Priority = 1;
                Player.SetActive(false);
            }
        }
    }
}
