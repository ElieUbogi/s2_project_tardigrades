﻿using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rigid;
    private GameObject safe;
    public static int cam;
    public GameObject menuPanel;
    public uint score;
    public bool Breaker;
    public static bool CanGo;
    public bool checker;
    public float vitesseX;
    public float vitesseY;
    public float vitesseZ;
    public List<GameObject> directionnal_zone;
    public List<GameObject> toRes = new List <GameObject>();
    public GameObject SavePos;
    private GameObject ActivTerrain;
    private PhotonView _view;
    
    // Start is called before the first frame update
    void Start()
    {
        _view = GetComponent<PhotonView>();
        SavePos = Instantiate(new GameObject());
        menuPanel = new GameObject();
        bool test = PhotonNetwork.isMasterClient;
        if (PhotonNetwork.isMasterClient)
        {
            ActivTerrain=GameObject.Find("terrain");
            safe = GameObject.Find("terrain").transform.Find("spawn").gameObject;
        }
        else
        {
            ActivTerrain=GameObject.Find("terrain2");
            safe = GameObject.Find("terrain2").transform.Find("spawn").gameObject;
        }
        resetV();
        this.transform.position = safe.transform.position;
        rigid = GetComponent<Rigidbody>();
        //menuPanel.SetActive(false);
        score = 0;
        CanGo = true;
        Breaker = false;
        foreach (GameObject a in directionnal_zone)
        {
            a.SetActive(false);
        }

    }
    public void resetV()
    {
        vitesseX = 0;
        vitesseY = 0;
        vitesseZ = 0;
    }
    
    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("safe"))
        {
            resetV();
            CanGo = true;
            Breaker = false;
            foreach (GameObject a in toRes)
            {
                a.SetActive(true);
            }

            SavePos.transform.position = this.transform.position;

            toRes = new List<GameObject>();
        }
        if (chose.gameObject.tag == ("PUGlass"))
        {
            Breaker = true;
            toRes.Add(chose.gameObject);
            chose.gameObject.SetActive(false);
        }
    }
    
    void OnCollisionEnter(Collision chose)
    {
        
        if (chose.gameObject.tag == ("Glass")&&Breaker)
        {
            toRes.Add(chose.gameObject);
            chose.gameObject.SetActive(false);
        }
        if (chose.gameObject.tag == ("Glass") && !Breaker)
        {
            CanGo = true;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (_view.isMine)
        {
            checker = CanGo;
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                resetV();
                CanGo = true;
            }

            if (CanGo)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if ((cam == 0 || cam == 1) && (!directionnal_zone[0].activeSelf))
                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = 1;
                        ChooseDirection(0);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;


                    }
                    else if ((cam == 2 || cam == 3) && (!directionnal_zone[2].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = -1;
                        vitesseZ = 0;

                        ChooseDirection(2);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                    else if ((cam == 4 || cam == 5) && (!directionnal_zone[1].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = -1;
                        ChooseDirection(1);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                    else if ((cam == 6 || cam == 7) && (!directionnal_zone[3].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 1;
                        vitesseZ = 0;
                        ChooseDirection(3);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;


                    }

                }

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if ((cam == 0 || cam == 1) && (!directionnal_zone[1].activeSelf))
                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = -1;
                        ChooseDirection(1);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                    else if ((cam == 2 || cam == 3) && (!directionnal_zone[3].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 1;
                        vitesseZ = 0;
                        ChooseDirection(3);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 4 || cam == 5) && (!directionnal_zone[0].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = 1;
                        ChooseDirection(0);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 6 || cam == 7) && (!directionnal_zone[2].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = -1;
                        vitesseZ = 0;
                        ChooseDirection(2);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if ((cam == 0 || cam == 1) && (!directionnal_zone[2].activeSelf))
                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = -1;
                        vitesseZ = 0;
                        ChooseDirection(2);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                    else if ((cam == 2 || cam == 3) && (!directionnal_zone[1].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = -1;
                        ChooseDirection(1);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 4 || cam == 5) && (!directionnal_zone[3].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 1;
                        vitesseZ = 0;
                        ChooseDirection(3);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 6 || cam == 7) && (!directionnal_zone[0].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = 1;
                        ChooseDirection(0);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }

                }

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if ((cam == 0 || cam == 1) && (!directionnal_zone[3].activeSelf))
                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 1;
                        vitesseZ = 0;
                        ChooseDirection(3);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;

                    }
                    else if ((cam == 2 || cam == 3) && (!directionnal_zone[0].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = 1;
                        ChooseDirection(0);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 4 || cam == 5) && (!directionnal_zone[2].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = -1;
                        vitesseZ = 0;
                        ChooseDirection(2);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                    else if ((cam == 6 || cam == 7) && (!directionnal_zone[1].activeSelf))

                    {
                        SavePos.transform.position = this.transform.position;
                        vitesseX = 0;
                        vitesseZ = -1;
                        ChooseDirection(1);
                        vitesseY = 0;
                        score += 1;
                        CanGo = false;
                    }
                }

                if (Input.GetKeyDown(KeyCode.Space) && (!directionnal_zone[4].activeSelf))
                {
                    SavePos.transform.position = this.transform.position;
                    vitesseX = 0;
                    vitesseY = 1;
                    vitesseZ = 0;
                    ChooseDirection(4);
                    score += 1;
                    CanGo = false;
                }

                if (Input.GetKeyDown(KeyCode.LeftControl) && (!directionnal_zone[5].activeSelf))
                {
                    SavePos.transform.position = this.transform.position;
                    vitesseX = 0;
                    vitesseY = -1;
                    vitesseZ = 0;
                    ChooseDirection(5);
                    score += 1;
                    CanGo = false;
                }
            }



            rigid.velocity = new Vector3(vitesseX * 400 * Time.deltaTime, vitesseY * 400 * Time.deltaTime,
                vitesseZ * 400 * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (menuPanel.active)
                {
                    menuPanel.SetActive(false);
                    score = 0;
                }

                this.transform.position = safe.transform.position;
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                resetV();
                CanGo = true;
                this.transform.position = SavePos.transform.position;
                foreach (GameObject a in directionnal_zone)
                {
                    a.SetActive(false);
                }
            }
        }
    }

    private void ChooseDirection(int n)
    
    {
        for (int i = 0; i < directionnal_zone.Count; i++)
        {
            if (n == i)
            {
                directionnal_zone[i].SetActive(true); 
            }
            else
            {
                directionnal_zone[i].SetActive(false);
            }
        }
    }
}
