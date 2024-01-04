using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayingViewChange : MonoBehaviour
{
    [SerializeField] ShotGun shotGun;
    [SerializeField] SceneReserch sceneReserch;
    [SerializeField] GameObject Player;

    public CinemachineVirtualCameraBase PlayerCamera;
    public CinemachineVirtualCameraBase UpCamera;
    // Start is called before the first frame update
    bool IsChange = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shotGun.IsShot && !IsChange) 
        {
            //if (sceneReserch.bulletRefCount == 1) { }
            StartCoroutine(viewChange());
        }
    }

    private IEnumerator viewChange()
    {
        Time.timeScale = 0.1f;

        yield return new WaitForSeconds(0.1f);

        PlayerCamera.Priority = 0;
        UpCamera.Priority = 1;
        Player.SetActive(false);
        Time.timeScale = 1.0f;
     
        IsChange = true;    
    }
}
