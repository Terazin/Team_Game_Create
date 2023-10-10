using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    bool toMainMenu = false;
    public GameObject uiElementToToggle;
    [SerializeField] float fadeDuration = 1f;
    [SerializeField] float displayImageDuration = 1f;
    [SerializeField] CanvasGroup canvasGroup;

    float m_Timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (toMainMenu)
        {
            FadeOut();
        }
    }
    public void ToggleUIElement()
    {
        uiElementToToggle.SetActive(!uiElementToToggle.activeSelf); // UI—v‘f‚Ì•\Ž¦/”ñ•\Ž¦‚ðØ‚è‘Ö‚¦‚é
    }
    public void ClickMenuButton()
    {
        toMainMenu = true;
        Time.timeScale = 1;
    }

    void FadeOut()
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            SceneManager.LoadScene("Main_menu");
        }
    }
}
