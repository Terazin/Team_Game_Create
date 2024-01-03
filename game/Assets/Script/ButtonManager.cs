using UnityEngine;
using UnityEngine.UI; // UI�v�f���g�����߂ɕK�v

public class ButtonManager : MonoBehaviour
{
    public Button Stage1;
    public Button Stage2;
    public Button Stage3;
    public Button Stage4;
    public Button Stage5;
    public Button Stage6;
    public Button Stage7;
    public Button Stage8;
    public Button Stage9;
    public Button Stage10;

    void Start()
    {
        // �e�{�^����OnClick�C�x���g�Ƀ��\�b�h��o�^
        Stage1.onClick.AddListener(() => DisableOtherButtons(Stage1));
        Stage2.onClick.AddListener(() => DisableOtherButtons(Stage2));
        Stage3.onClick.AddListener(() => DisableOtherButtons(Stage3));
        Stage4.onClick.AddListener(() => DisableOtherButtons(Stage4));
        Stage5.onClick.AddListener(() => DisableOtherButtons(Stage5));
        Stage6.onClick.AddListener(() => DisableOtherButtons(Stage6));
        Stage7.onClick.AddListener(() => DisableOtherButtons(Stage7));
        Stage8.onClick.AddListener(() => DisableOtherButtons(Stage8));
        Stage9.onClick.AddListener(() => DisableOtherButtons(Stage9));
        Stage10.onClick.AddListener(() => DisableOtherButtons(Stage10));
    }

    void DisableOtherButtons(Button clickedButton)
    {
        // �N���b�N���ꂽ�{�^���ȊO�𖳌���
        if (clickedButton != Stage1)
            Stage1.interactable = false;

        if (clickedButton != Stage2)
            Stage2.interactable = false;

        if (clickedButton != Stage3)
            Stage3.interactable = false;

        if (clickedButton != Stage4)
            Stage4.interactable = false;

        if (clickedButton != Stage5)
            Stage5.interactable = false;

        if (clickedButton != Stage6)
            Stage6.interactable = false;

        if (clickedButton != Stage7)
            Stage7.interactable = false;

        if (clickedButton != Stage8)
            Stage8.interactable = false;

        if (clickedButton != Stage9)
            Stage9.interactable = false;

        if (clickedButton != Stage10)
            Stage10.interactable = false;
    }
}
