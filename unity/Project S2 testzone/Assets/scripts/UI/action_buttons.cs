using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class action_buttons : MonoBehaviour
{
    private bool optionMenu;
    public GameObject escapeCanvas, optionCanvas;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToSelection()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }

    public void OptionMenuActivation()
    {
        escapeCanvas.SetActive(false);
        optionCanvas.SetActive(true);
    }

    public void ReturnToEscapeCanvas()
    {
        escapeCanvas.SetActive(true);
        optionCanvas.SetActive(false);  
    }

    public void Quit()
    {
        Application.Quit();
    }
}