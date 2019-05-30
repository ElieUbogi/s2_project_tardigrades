using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public player Player;
    public Text Score;

    void Update()
    {
        Score.text = Player.score.ToString();
    }
}
