using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{
    public GameObject safe;
    public GameObject menuPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        //safe = GameObject.Find("safe");
    }
    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("Player"))
        {
            chose.transform.position = safe.transform.position;
            menuPanel.SetActive(true);
            chose.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}