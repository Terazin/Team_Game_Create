using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] private Image uiFill;
    [SerializeField] private TextMeshProUGUI uiText;
    [SerializeField] private float CountTime;
    private void Update()
    {
        float timer = CountTime - Time.time;
        int seconds = Mathf.FloorToInt(timer % 60);
        uiFill.fillAmount = Mathf.InverseLerp(0, CountTime, timer);
        uiText.text =  seconds.ToString("00");

        
    }
  
}


