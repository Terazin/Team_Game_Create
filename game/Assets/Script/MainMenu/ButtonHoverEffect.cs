using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject imageToShow; // ボタンの隣に表示する画像

    public void OnPointerEnter(PointerEventData eventData)
    {
        // カーソルがボタンに入ったときに呼び出されるメソッド
        imageToShow.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // カーソルがボタンから出たときに呼び出されるメソッド
        imageToShow.SetActive(false);
    }
}
