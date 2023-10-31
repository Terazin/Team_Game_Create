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
        loadPanel = GameObject.Find("Canvas").transform.Find
               ("LoadPanel").gameObject;

        loadSlider = loadPanel.transform.Find
               ("Slider").GetComponent<Slider>();

        loadProgressText = loadSlider.transform.Find
               ("LoadText").GetComponent<Text>();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickFirstStageButton()
    {
        StartCoroutine(LoadScene("FirstStage"));
    }
    public void ClickSecondStageButton()
    {
        StartCoroutine(LoadScene("SecondStage"));
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
