using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour
{
    public List<Button> buttons;

    private void Update()
    {
        buttons[0].onClick.AddListener(() => Actions(0));
        buttons[1].onClick.AddListener(() => Actions(1));
    }

    private void Actions(int i)
    {
        switch(i)
        {
            case 0:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 1:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
        }
    }
}