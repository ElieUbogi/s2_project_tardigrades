using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class action_buttons : MonoBehaviour
{
    public List<GameObject> buttons;

    // Update is called once per frame
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

    public void Quit()
    {
        Application.Quit();
    }
}