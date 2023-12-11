using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadScript : MonoBehaviour
{
    GameObject loadPanel;
    Slider loadSlider;
    Text loadProgressText;

    AsyncOperation async;

    void Start()
    {
        /*loadPanel = GameObject.Find("Canvas").transform.Find
               ("LoadPanel").gameObject;

        loadSlider = loadPanel.transform.Find
               ("Slider").GetComponent<Slider>();

        loadProgressText = loadSlider.transform.Find
               ("LoadText").GetComponent<Text>();*/
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickFirstStageButton()
    {
        SceneManager.LoadScene("FirstStage");
    }
    public void ClickSecondStageButton()
    {
        SceneManager.LoadScene("SecondStage");
    }

    public void ClickThirdStageButton()
    {
        SceneManager.LoadScene("ThirdStage");
    }
    public void ClickFourthStageButton()
    {
        SceneManager.LoadScene("FourthStage");
    }
    public void ClickFivethStageButton()
    {
        SceneManager.LoadScene("FifthStage");
    }
    public void ClickSixthStageButton()
    {
        SceneManager.LoadScene("SixthStage");
    }
    public void ClicknanaButton()
    {
        SceneManager.LoadScene("SeventhStage");
    }
    public void ClickhatiButton()
    {
        SceneManager.LoadScene("EighthStage");
    }
    public void ClickQButton()
    {
        SceneManager.LoadScene("NinthStage");
    }
    public void ClickzyuuButton()
    {
        SceneManager.LoadScene("TenthStage");
    }
    public void ClickMainMenuButton()
    {
        SceneManager.LoadScene("MainMenuNew");
    }
    public void ClickSelectButton()
    {
        SceneManager.LoadScene("Stege_Select");
    }
    /*public IEnumerator LoadScene(string sceneName)
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

    }*/
}
