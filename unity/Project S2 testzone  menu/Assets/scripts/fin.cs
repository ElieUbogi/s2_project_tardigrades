using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{
    public static bool mainMenu;
    public bool test;
    public static bool canGO;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu = false;
        test = false;
    }
    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("Player"))
        {
            mainMenu = true;
           

        }
    }
    void OnTriggerExit(Collider chose)
    {
        if (chose.gameObject.tag == ("Player"))
        {
            mainMenu = false;
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
