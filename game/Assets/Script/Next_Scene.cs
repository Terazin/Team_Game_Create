using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour
{

    GameObject loadPanel;
    Slider loadSlider;
    Text loadProgressText;

    AsyncOperation async;

    void Start()
    {
        loadPanel = GameObject.Find("Canvas").transform.Find
               ("LoadPanel").gameObject;

        loadSlider = loadPanel.transform.Find
               ("Slider").GetComponent<Slider>();

        loadProgressText = loadSlider.transform.Find
               ("LoadText").GetComponent<Text>();
    }
    public void ClickStartButton()
    {
        SceneManager.LoadScene("Main_menu");
    }
    public void ClickOperationButton()
    {
        SceneManager.LoadScene("Operation");
    }

    public void ClickOptionButton()
    {
        SceneManager.LoadScene("Option");
    }

    public void ClickCreditButton()
    {
        SceneManager.LoadScene("Credit");
    }

    public void ClickStage_SelectButton()
    {
        SceneManager.LoadScene("Stege_Select");
    }

    public void ClickFirstStageButton()
    {
        StartCoroutine(LoadScene("FirstStage"));
    }
    public void ClickSecondStageButton()
    {
        SceneManager.LoadScene("SecondStage");
    }

    public void ClickThirdStageButton()
    {
        StartCoroutine(LoadScene("ThirdStage"));
    }
    public IEnumerator LoadScene(string sceneName)
    {
        async = SceneManager.LoadSceneAsync(sceneName);
        loadPanel.SetActive(true);

        while (!async.isDone)
        {
            loadProgressText.text = "êiçsíÜ..." + (async.progress * 100) + "%";

            float progressValue = async.progress;
            loadSlider.value = progressValue;

            yield return null;

        }
        if (async.isDone) 
        {
        loadPanel.SetActive(false);
        }

    }


}
