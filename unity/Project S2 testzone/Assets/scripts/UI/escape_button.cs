using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escape_button : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;
    public GameObject safe;
    private bool optionMenu = false;
    private int i = 0;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        // desactivate the cube when we press escape and reactivate it when we repress the button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (i % 2 == 0)
            {
                panel.SetActive(true);
                player.SetActive(false);
            }
            else
            {
                panel.SetActive(false);
                player.SetActive(true);
            }
            i++;
        }
    }
}
