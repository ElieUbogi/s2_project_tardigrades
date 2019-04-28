using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSide : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("Face"))
        {
            player.CanGo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
