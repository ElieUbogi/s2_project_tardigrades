using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

    public void NextLevelNetwork()
    {
        GameObject[] play = GameObject.FindGameObjectsWithTag("Player");
        foreach (var e in play)
        {
            e.GetComponent<PhotonView>().RPC("RPCNextLevel", PhotonTargets.AllBuffered);
        }
        
    }

    public static void NextLevelStatic()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
     //Load the next Level for Network
    public static void NextLevelStaticNetwork()
    {
        string actualLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Net_Level_" + (Int32.Parse(""+actualLevel[actualLevel.Length -1])+2));
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToNetwork()
    {
        SceneManager.LoadScene("Connection in Network");
    }

    public void GoToSelection()
    {
        SceneManager.LoadScene("select_lvl");
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