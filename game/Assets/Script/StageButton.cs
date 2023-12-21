using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用

public class StageButton : MonoBehaviour
{
	[SerializeField] Scrollbar scrollbar;
	[SerializeField] Button[] StageButtons;
	[SerializeField] float moveOffset;
	[SerializeField] int length;

	float head = 0;
	int currentIndex;


	void Start()
	{
		// 最初に選択状態にしたいボタンの設定
		StageButtons[0].Select();

        for (int i = 0; i < StageButtons.Length; i++)
        {
			int j = i;
            Button item = StageButtons[i];
            EventTrigger eventTrigger =	item.gameObject.AddComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.Select;
			entry.callback.AddListener(eventData => UpdateButtonSelect(j));
			eventTrigger.triggers.Add(entry);
        }
	}

	void UpdateButtonSelect(int i)
    {
		StageButtons[currentIndex].GetComponent<PopupScript>().enabled = false;
		StageButtons[i].GetComponent<PopupScript>().enabled = true;
		currentIndex = i;

		if (i < head)
		{
			head--;
			scrollbar.value -= moveOffset;
        }
		else if (head + length <= i)
        {
			head++;
			scrollbar.value += moveOffset;
		}
	}
}	