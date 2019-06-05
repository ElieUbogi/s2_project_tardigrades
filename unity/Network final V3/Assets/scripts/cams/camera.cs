using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject caméra1;
    public GameObject caméra2;
    public GameObject caméra3;
    public GameObject caméra4;
    public GameObject caméra5;
    public GameObject caméra6;
    public GameObject caméra7;
    public GameObject caméra8;
    public List<GameObject> allCam;

    private PhotonView _view;
    // Start is called before the first frame update
    void Start()
    {

        allCam.Add(caméra1);
        allCam.Add(caméra2);
        allCam.Add(caméra3);
        allCam.Add(caméra4);
        allCam.Add(caméra5);
        allCam.Add(caméra6);
        allCam.Add(caméra7);
        allCam.Add(caméra8);
        SetCamera(0);
        bool isSolo = SceneManager.GetActiveScene().name[0] == 'L';
        
    }

    public void SetCamera(int n)
    {
        for (int i = 0; i < allCam.Count; i++)
        {
            allCam[i].SetActive(i==n);
        }
    }

    public void SetCameraOther(List<GameObject> lCam)
    {
        foreach (var e in lCam)
        {
            e.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!isSolo)
        {
            _view = transform.root.GetComponent<PhotonView>();
        }
 
        if (isSolo ||_view.isMine)
        {
            if (PhotonNetwork.isMasterClient)
            {
                SetCameraOther(GameObject.Find("terrain2").transform.Find("Cameras").GetComponent<camera>().allCam);
            }
            else
            {
                SetCameraOther(GameObject.Find("terrain").transform.Find("Cameras").GetComponent<camera>().allCam);
            }
            if(Input.GetKeyDown(KeyCode.F1))
            {
            caméra1.SetActive(true);
            caméra2.SetActive(false);
            caméra3.SetActive(false);
            caméra4.SetActive(false);
            caméra5.SetActive(false);
            caméra6.SetActive(false);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F2))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(true);
            caméra3.SetActive(false);
            caméra4.SetActive(false);
            caméra5.SetActive(false);
            caméra6.SetActive(false);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F3))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(false);
            caméra3.SetActive(true);
            caméra4.SetActive(false);
            caméra5.SetActive(false);
            caméra6.SetActive(false);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F4))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(false);
            caméra3.SetActive(false);
            caméra4.SetActive(true);
            caméra5.SetActive(false);
            caméra6.SetActive(false);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F5))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(false);
            caméra3.SetActive(false);
            caméra4.SetActive(false);
            caméra5.SetActive(true);
            caméra6.SetActive(false);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F6))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(false);
            caméra3.SetActive(false);
            caméra4.SetActive(false);
            caméra5.SetActive(false);
            caméra6.SetActive(true);
            caméra7.SetActive(false);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F7))
            {
            caméra1.SetActive(false);
            caméra2.SetActive(false);
            caméra3.SetActive(false);
            caméra4.SetActive(false);
            caméra5.SetActive(false);
            caméra6.SetActive(false);
            caméra7.SetActive(true);
            caméra8.SetActive(false);
    
            }
            if(Input.GetKeyDown(KeyCode.F8))
        {
        caméra1.SetActive(false);
        caméra2.SetActive(false);
        caméra3.SetActive(false);
        caméra4.SetActive(false);
        caméra5.SetActive(false);
        caméra6.SetActive(false);
        caméra7.SetActive(false);
        caméra8.SetActive(true);

        }
        }
    }
}
