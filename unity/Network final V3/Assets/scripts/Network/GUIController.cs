using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIController : MonoBehaviour
{
    Text statusText;
    Text masterText;

    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        statusText = GameObject.Find("statusText").GetComponent<Text>();
        masterText = GameObject.Find("masterText").GetComponent<Text>();
        canvas = this.transform.Find("Canvas").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            canvas.SetActive(!canvas.GetActive());
        }

        statusText.text = "Status : " + PhotonNetwork.connectionStateDetailed.ToString();
        masterText.text = "isMaster :" + PhotonNetwork.isMasterClient;
    }
}
