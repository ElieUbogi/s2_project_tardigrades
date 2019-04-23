using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject caméra1;
    public GameObject caméra2;
    public GameObject caméra3;
    public GameObject caméra4;
    public GameObject caméra5;
    public GameObject caméra6;
    public GameObject caméra7;
    public GameObject caméra8;

    // Start is called before the first frame update
    void Start()
    {
        
        caméra1.SetActive(true);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
        caméra1.SetActive(true);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F2))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(true);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F3))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(true);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F4))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(true);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F5))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(true);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F6))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(true);
        caméra7.SetActive(false);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F7))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(true);
        caméra8.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.F8))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(true);

        }
    }
}
