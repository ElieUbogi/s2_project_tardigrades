using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    public List<GameObject> allCam;

    private PhotonView _view;
    private bool isSolo;

    private Dictionary<string, int> toCam;
    // Start is called before the first frame update
    void Start()
    
    { 
        allCam = new List<GameObject>();
        toCam = new Dictionary<string, int>
        {
            {"CamSEH",0},
            {"CamSWH",1},
            {"CamNEH",2},
            {"CamNWH",3},
            {"CamSEB",4},
            {"CamSWB",5},
            {"CamNEB",6},
            {"CamNWB",7}
            
        };
        for (int i = 0; i < 8; i++)
        {
            string s = "";
            /*
          * H = y
          * B = -y
          * N = z
          * S = -z
          * E = x
          * W = -x
          */
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

                if (toCam["Cam"+s]<allCam.Count)
                {
                    allCam.Insert(toCam["Cam" +s],this.transform.Find("Cam" + s).gameObject); 
                }
                else
                {
                    allCam.Add(this.transform.Find("Cam" + s).gameObject);
                }

            }

            SetCamera(0);
            isSolo = SceneManager.GetActiveScene().name[0] == 'L';
        }
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
            
            
            if (PhotonNetwork.isMasterClient)
            {
                SetCameraOther(GameObject.Find("terrain2").transform.Find("Cameras").GetComponent<camera>().allCam);
            }
            else
            {
                SetCameraOther(GameObject.Find("terrain").transform.Find("Cameras").GetComponent<camera>().allCam);
            }
        }

        _view = transform.root.GetComponent<PhotonView>();
        if (isSolo ||_view.isMine)
        {
            if(Input.GetKeyDown(KeyCode.F1))
            {
             SetCamera(0);
    
            }
            if(Input.GetKeyDown(KeyCode.F2))
            {
                SetCamera(1);
    
            }
            if(Input.GetKeyDown(KeyCode.F3))
            {
                SetCamera(2);
            }
            if(Input.GetKeyDown(KeyCode.F4))
            {
                SetCamera(3);
            }
            if(Input.GetKeyDown(KeyCode.F5))
            {
                SetCamera(4);
            }
            if(Input.GetKeyDown(KeyCode.F6))
            {
                SetCamera(5);
            }
            if(Input.GetKeyDown(KeyCode.F7))
            {
                SetCamera(6);
            }
            if(Input.GetKeyDown(KeyCode.F8))
            {
                SetCamera(7);
            }
        }
    }
}
