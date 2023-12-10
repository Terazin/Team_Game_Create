using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseTest : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Button focusButton;
    bool IsPush;

    // Start is called before the first frame update
    void Start()
    {
        IsPush = false;
        focusButton = focusButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !IsPush)
        {
            panel.SetActive(true);
            IsPush = true;
            //�����I���{�^���̏�����
            EventSystem.current.SetSelectedGameObject(null);
            //�����I���{�^���̍Ďw��
            focusButton.Select();
        }
        else if (Input.GetKeyDown(KeyCode.Q) && IsPush)
        {
            panel.SetActive(false);
            IsPush = false;
        }

    }
}
