using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject Door;

    public bool state;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider chose)
    {
        

        
        if (chose.gameObject.tag == ("Player"))
        {
            if (state)
            {
                state = false;
            }
            else
            {
                state = true;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Door.SetActive(state);
        //changer la couleur en fonction de state ici
    }
}
