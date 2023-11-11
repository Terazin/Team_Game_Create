using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame_UI_Show : MonoBehaviour
{
    [SerializeField] CanvasGroup operationInstructon;
    [SerializeField] CanvasGroup MapView;
    [SerializeField] CanvasGroup gameSceneUI;
    bool Is_X_Push = false;
    bool Is_Y_Push = false;
    int alphaNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Is_X_Push && !Is_Y_Push) 
        {
            if (Input.GetKeyDown("joystick button 2"))
            {
                operationInstructon.alpha = alphaNum;
                gameSceneUI.alpha -= alphaNum;
                Is_X_Push = true;
            }
            else if (Input.GetKeyDown("joystick button 3"))
            {
                MapView.alpha = alphaNum;
                gameSceneUI.alpha -= alphaNum;
                Is_Y_Push = true;
            }
        }
        else
        {
            if ((Input.GetKeyDown("joystick button 2")) && Is_X_Push) 
            {
                operationInstructon.alpha -= alphaNum;
                gameSceneUI.alpha = alphaNum;
                Is_X_Push = false;
            }
            else if ((Input.GetKeyDown("joystick button 3")) && Is_Y_Push) 
            {
                MapView.alpha -= alphaNum;
                gameSceneUI.alpha = alphaNum;
                Is_Y_Push = false;
            }
        }
    }
}
