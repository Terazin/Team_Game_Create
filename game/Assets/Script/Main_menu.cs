using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{

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

    public void ClickStage_sub1Button()
    {
        SceneManager.LoadScene("Stage_sub1");
    }
    public void ClickStage_sub2Button()
    {
        SceneManager.LoadScene("Stage_sub2");
    }

}
