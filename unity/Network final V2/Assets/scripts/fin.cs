using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fin : MonoBehaviour
{
    public GameObject endpanel;

    private PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        //safe = GameObject.Find("safe");
    }
    //[PunRPC]
    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.CompareTag(("Player")) )
        {/*
            chose.transform.position = safe.transform.position;
            menuPanel.SetActive(true);
            chose.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            */
            
            //action_buttons.NextLevelStatic();
            view = this.GetComponent<PhotonView>();
            view = PhotonView.Get(chose);
            if (view.isMine)
            {
                //view.RPC("ActiveEndPanelNetwork",PhotonTargets.Others);
                ActiveWinEndPanel();
                view.RPC("ActiveLoseEndPanel", PhotonTargets.OthersBuffered);
            }
            else
            {
                ActiveLoseEndPanel();
            }
        }
    }

    // the [PunRpc] is for call to all players
    [PunRPC]
    void ActiveEndPanelNetwork()
    {   GameObject.Find("endGame").transform.Find("WinNet").gameObject.SetActive(false);
        GameObject.Find("endGame").transform.Find("LoseNet").gameObject.SetActive(true);
    }
    [PunRPC]
    void ActiveWinEndPanel()
    {
        endpanel.transform.Find("WinNet").gameObject.SetActive(true);
        endpanel.transform.Find("LoseNet").gameObject.SetActive(false);
    }
    [PunRPC]
    void ActiveLoseEndPanel()
    {
        endpanel.transform.Find("WinNet").gameObject.SetActive(false);
        endpanel.transform.Find("LoseNet").gameObject.SetActive(true);
    }
    void Update()
    {

    }
}