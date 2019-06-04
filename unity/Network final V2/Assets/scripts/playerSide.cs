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
        if (chose.gameObject.CompareTag(("Face")))
        {
            this.transform.parent.parent.GetComponent<player>().CanGo = true; //find the associated player and set the Cango to true.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
