using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationInstructionsShow : MonoBehaviour
{
    public CanvasGroup operationInstructon;
    bool IsPush = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 2") && !IsPush)
        {
            operationInstructon.alpha = 1;
            IsPush = true;
        }
        else if (Input.GetKeyDown("joystick button 2") && IsPush)
        {
            operationInstructon.alpha -= 1;
            IsPush = false;
        }
    }
}
