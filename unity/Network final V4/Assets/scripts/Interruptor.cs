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

    private void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag=="Player")
        {
            state = !state;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Door.SetActive(state);
    }
}
