using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkController : MonoBehaviour
{
    private string _gameVersion = "0.1";
    public GameObject player;
    public GameObject terrain1;
    public GameObject terrain2;

    private GameObject ActiveTerrain;
    //public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(_gameVersion);
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
    void OnJoinedRoom()
    {
        Debug.Log("Connect Succesful !");
        Vector3 cord;
        if (PhotonNetwork.isMasterClient)
        {
            ActiveTerrain = terrain1;
        }
        else
        {
            ActiveTerrain = terrain2;
        }

        cord = ActiveTerrain.transform.Find("Spawn").position;
        
        player.transform.position = cord;
       

   
        PhotonNetwork.Instantiate("Prefabs/Player/" + player.name, player.transform.position, Quaternion.identity, 0); //Quaternion.indentity = player.rotation
    }

}
