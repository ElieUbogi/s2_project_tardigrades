using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject star;
    public player Player;

    // Update is called once per frame
    void Update()
    {
        if (menuPanel.active)
        {
            uint score = Player.score;
            if (score <= 6)
            {
                switch (star.tag)
                {
                    case "star_1":
                        star.SetActive(true);
                        break;
                    case "star_2":
                        star.SetActive(true);
                        break;
                }
            }
        }
    }
}
