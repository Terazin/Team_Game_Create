using UnityEngine;
using UnityEngine.UI;

public class ButtonManager2 : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        // �e�{�^����OnClick�C�x���g�Ƀ��\�b�h��o�^
        button1.onClick.AddListener(() => DisableOtherButtons(button1));
        button2.onClick.AddListener(() => DisableOtherButtons(button2));
        button3.onClick.AddListener(() => DisableOtherButtons(button3));
    }

    void DisableOtherButtons(Button clickedButton)
    {
        if (clickedButton != button1)
            button1.interactable = false;

        if (clickedButton != button2)
            button2.interactable = false;

        if (clickedButton != button3)
            button3.interactable = false;

        // �����őS�{�^�����ēx�L���ɂ��邽�߂̒x����ݒ�
        Invoke("EnableAllButtons", 1); // 5�b��ɑS�{�^����L����
    }

    void EnableAllButtons()
    {
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
    }
}
