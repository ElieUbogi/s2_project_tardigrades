using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escape_button : MonoBehaviour
{
    private GameObject _player;
    public GameObject panel;
    private bool optionMenu = false;
    private int i = 0;

    private void Start()
    {
        panel.SetActive(false);

    }

    private static GameObject FindCorrectPlayer(GameObject[] players)
    {
        if (SceneManager.GetActiveScene().name[0] != 'N')
        {
            try
            {
                if (players.Length == 0)
                {
                    return GameObject.Find("player");
                }
                else
                {
                    return players[1];
                }

            }
            catch
            {
                // ignored
            }
        }
        
        foreach (GameObject p in players)
        {
            if (p.GetComponent<PhotonView>().isMine)
            {
                return p;
            }
        }
        Debug.Log("the player has not been fund !!");
        return null;
    }

    private void Update()
    {
        // desactivate the cube when we press escape and reactivate it when we repress the button

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (i % 2 == 0)
            {
                _player = FindCorrectPlayer(GameObject.FindGameObjectsWithTag("Player")); // take all active player in the scene, and select the correct player
                panel.SetActive(true);
                _player.SetActive(false);
            }
            else
            {
                panel.SetActive(false);
                _player.SetActive(true);
                _player = FindCorrectPlayer(GameObject.FindGameObjectsWithTag("Player")); // take all active player in the scene, and select the correct player
            }
            i++;
        }
    }
}
