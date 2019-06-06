using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionterrainNet : MonoBehaviour
{
    // Start is called before the first frame update
    [PunRPC]
    void RPCNextLevel()
    {
        string actualLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Net_Level_" + (Int32.Parse(""+actualLevel[actualLevel.Length -1])+2));
    }
    
    [PunRPC]
    void ActiveLoseEndPanel()
    {
        GameObject.Find("endGame").transform.Find("WinNet").gameObject.SetActive(false);
        GameObject.Find("endGame").transform.Find("LoseNet").gameObject.SetActive(true);
    }
    
    [PunRPC]
    void ActiveWinEndPanel()
    {
        GameObject.Find("endGame").transform.Find("WinNet").gameObject.SetActive(true);
        GameObject.Find("endGame").transform.Find("LoseNet").gameObject.SetActive(false);
    }

}
