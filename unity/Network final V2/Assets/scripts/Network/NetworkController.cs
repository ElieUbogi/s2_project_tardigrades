using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class NetworkController : MonoBehaviour
{
    private string _gameVersion = "0.1";
    public GameObject player;
    public GameObject terrain1;
    public GameObject terrain2;

    //public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.connected)//Joined another Scene
        {
            PutPlayers();
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings(_gameVersion);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* méthodes de callback de photon */
    void OnJoinedLobby() //when we join the Server
    {
        Debug.Log("trying to connect in a Room");
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed() //if connection to a Room failed
    {
        Debug.Log("Can't join random room ! So, we create a new one");
        PhotonNetwork.CreateRoom(null);
    }

    public void PutPlayers()
    {
        if (PhotonNetwork.isMasterClient)
        {
        
            
            PhotonNetwork.Instantiate("Prefabs/" + player.name, terrain1.transform.Find("spawn").position, Quaternion.identity, 0); //Quaternion.indentity = player.rotation
            if (SceneManager.GetActiveScene().name != "Net_Level_1")
            {
                terrain1.transform.Find("Cameras").GetComponent<camera>()
                    .SetCameraOther(terrain2.transform.Find("Cameras").GetComponent<camera>()
                        .allCam); //Set all other camera to false
            }
            else
            {
                terrain2.transform.Find("Cameras").gameObject.SetActive(false);
            }
            // g.GetComponent<player>().GoStart(terrain);
            terrain1.transform.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.masterClient);
              
        }
        
      
        else
        {
            PhotonNetwork.Instantiate("Prefabs/" + player.name, terrain2.transform.Find("spawn").position,
                Quaternion.identity, 0);
            if (SceneManager.GetActiveScene().name != "Net_Level_1")
            {
                terrain2.transform.Find("Cameras").GetComponent<camera>().SetCameraOther(terrain1.transform.Find("Cameras").GetComponent<camera>().allCam);
            }
            else
            {
                terrain1.transform.Find("Cameras").gameObject.SetActive(false);
            }
           
            terrain2.transform.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player);
     
        }
        
    }
    
    void OnJoinedRoom()
    {
        Debug.Log("Connect Succesful !");
        SceneManager.LoadScene("Net_Level_1");
    }

}
