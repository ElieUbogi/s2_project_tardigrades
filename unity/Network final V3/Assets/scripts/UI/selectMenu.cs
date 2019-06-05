using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectMenu : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void level2()
    {
        SceneManager.LoadScene("Level_2");
    }
}
