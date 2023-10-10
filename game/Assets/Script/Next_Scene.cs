using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour
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

    public void ClickFirstStageButton()
    {
        SceneManager.LoadScene("FirstStage");
    }
    public void ClickSecondStageButton()
    {
        SceneManager.LoadScene("SecondStage");
    }

}
