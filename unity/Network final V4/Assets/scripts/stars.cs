using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public player Player;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public int three_star;

    // Update is called once per frame
    void Update()
    {
        /*uint score = Player.score;
        if (score <= three_star)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (score > three_star && score <= three_star * 1.2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (score > three_star * 1.2 && score <= three_star * 1.5)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }*/
    }
}
