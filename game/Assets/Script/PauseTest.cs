using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseTest : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject option;
    [SerializeField] Button focusButton;
    [SerializeField] Button optionFirstButton;
    bool IsPush;
    bool IsOptionPush;

    // Start is called before the first frame update
    void Start()
    {
        IsPush = false;
        IsOptionPush = false;
        focusButton = focusButton.GetComponent<Button>();
        optionFirstButton = optionFirstButton.GetComponent<Button>();
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
        else if (Input.GetKeyDown(KeyCode.Q) && IsPush && !IsOptionPush) 
        {
            panel.SetActive(false);
            IsPush = false;
        }

    }

    public void optionPush() //pause��option�{�^����OnClick()�ɓo�^
    {
        panel.SetActive(false);
        option.SetActive(true);
        //�����I���{�^���̏�����
        EventSystem.current.SetSelectedGameObject(null);
        //�����I���{�^���̍Ďw��
        optionFirstButton.Select();
        IsOptionPush = true;
    }

    public void backPush() //option��back�{�^����OnClick()�ɓo�^
    {
        option.SetActive(false);
        panel.SetActive(true);
        //�����I���{�^���̏�����
        EventSystem.current.SetSelectedGameObject(null);
        //�����I���{�^���̍Ďw��
        focusButton.Select();
        IsOptionPush = false;
    }
}
