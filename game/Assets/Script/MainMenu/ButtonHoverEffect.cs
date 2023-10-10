using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject imageToShow; // �{�^���ׂ̗ɕ\������摜

    public void OnPointerEnter(PointerEventData eventData)
    {
        // �J�[�\�����{�^���ɓ������Ƃ��ɌĂяo����郁�\�b�h
        imageToShow.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // �J�[�\�����{�^������o���Ƃ��ɌĂяo����郁�\�b�h
        imageToShow.SetActive(false);
    }
}
