using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectMenu : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene(2);
    }

    public void level2()
    {
        SceneManager.LoadScene(3);
    }
}
