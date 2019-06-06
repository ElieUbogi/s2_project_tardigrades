using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject Door;

    public bool state;

    private Renderer colorEmission;
    // Start is called before the first frame update
    void Start()
    {
        colorEmission = GetComponent<Renderer>();
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
        if (state)
        {
            colorEmission.material.SetColor("_EmissionColor", Color.red);
        }
        else
        {
            colorEmission.material.SetColor("_EmissionColor", Color.green);            
        }

        Door.SetActive(state);
    }
}
