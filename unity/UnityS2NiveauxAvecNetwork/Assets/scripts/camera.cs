using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
   
    PhotonView view;
    public GameObject terrain1;
    public GameObject terrain2;
    private GameObject ActiveTerrain;
    private List<Camera> allCam;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnJoinedRoom()
    {
        allCam = new List<Camera>();
        string s = "";
        if (PhotonNetwork.isMasterClient)
        {
            ActiveTerrain = terrain1;
           // Display.displays[0].Activate();
        }
        else
        {
            ActiveTerrain = terrain1;
           // Display.displays[1].Activate();
        }

        for (int i = 0; i < 8; i++)
        {
            if (i < 4)
            {
                s += 'S';
                
            }
            else
            {
                s += 'N';
                
            }

            if (i % 4 <= 1)
            {
                s += 'E';
               
            }
            else
            {
                s += 'W';
                
            }

            if (i % 2 == 0)
            {
                s += 'H';
                
            }
            else
            {
                s += 'B';
                
            }


            allCam.Add(ActiveTerrain.transform.Find("Cameras").Find("Cam"+s).Find("Camera").gameObject.GetComponent<Camera>());
            s = "";
            // ajout de la camera en fonction de s "elle permet de bien selectionner les 8"
        }
        
        
        
        
        ActiveCam(0);

    }
    private void ActiveCam(int n)
    
    {
        for (int i = 0; i < allCam.Count; i++)
        {
            if (n == i)
            {
                allCam[i].enabled = true;
            }
            else
            {
                allCam[i].enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
        ActiveCam(0);

        }
        if(Input.GetKeyDown(KeyCode.F2))
        {
       
            ActiveCam(1);
        }
        if(Input.GetKeyDown(KeyCode.F3))
        {
            ActiveCam(2);
        }
        if(Input.GetKeyDown(KeyCode.F4))
        {
            ActiveCam(3);

        }
        if(Input.GetKeyDown(KeyCode.F5))
        {
         ActiveCam(4);

        }
        if(Input.GetKeyDown(KeyCode.F6))
        {
            ActiveCam(5);

        }
        if(Input.GetKeyDown(KeyCode.F7))
        {
            ActiveCam(6);

        }
        if(Input.GetKeyDown(KeyCode.F8))
        {
            ActiveCam(7);

        }
    }
}
