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
    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag==("Player"))
        {
            /*
                chose.transform.position = safe.transform.position;
                menuPanel.SetActive(true);
                chose.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            */

            chose.gameObject.GetComponent<player>().resetV();

            bool isSolo = SceneManager.GetActiveScene().name[0] == 'L';
            if (!isSolo)
            {

                view = chose.GetComponent<PhotonView>();
                if (view.isMine)
                {
                    ActiveWinEndPanel();
                    PhotonView testView = GameObject.Find("terrain").GetPhotonView();
                    if (!testView.isMine)
                    {
                        testView.RPC("ActiveLoseEndPanel", testView.owner);

                    }
                    else
                    {
                        testView = GameObject.Find("terrain2").GetPhotonView();
                        testView.RPC("ActiveLoseEndPanel", testView.owner);
                    }
                }
                else
                {
                    ActiveLoseEndPanel();
                }

            }
            else
            {
                endpanel.SetActive(true);
                Debug.Log("j'aime pas le foot");
            }
        }
    }

    // the [PunRpc] is for call to all players
    [PunRPC]
    void ActiveEndPanelNetwork()
    {   GameObject.Find("endGame").transform.Find("WinCan").gameObject.SetActive(false);
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