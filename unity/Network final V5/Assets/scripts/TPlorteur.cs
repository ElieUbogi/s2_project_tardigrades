using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlorteur : MonoBehaviour
{
    public GameObject Arrivée;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("Player"))
        {
            chose.gameObject.transform.position = Arrivée.transform.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
