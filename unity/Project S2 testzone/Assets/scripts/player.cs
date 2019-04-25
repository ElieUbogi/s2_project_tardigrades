using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rigid;
    public GameObject safe;
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

    
    // Start is called before the first frame update
    void Start()
    {
        resetV();
        this.transform.position = safe.transform.position;
        rigid = GetComponent<Rigidbody>();
        menuPanel.SetActive(false);
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
        checker = CanGo;
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            resetV();
            CanGo =true;
        }
        if(CanGo)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow)&&(!directionnal_zone[0].activeSelf))
            {
                vitesseX = 0;
                vitesseY = 0;
                vitesseZ = 1;
                ChooseDirection(0);
                score+=1;
                CanGo = false;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow)&&(!directionnal_zone[1].activeSelf))
            {
                vitesseX = 0;
                vitesseY = 0;
                vitesseZ = -1;
                ChooseDirection(1);
                score+=1;
                CanGo = false;
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow)&&(!directionnal_zone[2].activeSelf))
            {
                vitesseX = -1;
                vitesseY = 0;
                vitesseZ = 0;
                ChooseDirection(2);
                score+=1;
                CanGo = false;
                
            }
            if(Input.GetKeyDown(KeyCode.RightArrow)&&(!directionnal_zone[3].activeSelf))
            {
                vitesseX = 1;
                vitesseY = 0;
                vitesseZ = 0;
                ChooseDirection(3);
                score+=1;
                CanGo = false;
            }
            if(Input.GetKeyDown(KeyCode.Space)&&(!directionnal_zone[4].activeSelf))
            {
                vitesseX = 0;
                vitesseY = 1;
                vitesseZ = 0;
                ChooseDirection(4);
                score+=1;
                CanGo = false;
            }
            if(Input.GetKeyDown(KeyCode.LeftControl)&&(!directionnal_zone[5].activeSelf))
            {
                vitesseX = 0;
                vitesseY = -1;
                vitesseZ = 0;
                ChooseDirection(5);
                score+=1;
                CanGo = false;
            }
            
        }
        
        
        rigid.velocity = new Vector3(vitesseX * 400 * Time.deltaTime,vitesseY * 400* Time.deltaTime,vitesseZ * 400 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (menuPanel.active)
            {
                menuPanel.SetActive(false);
                score = 0;
            }
            this.transform.position = safe.transform.position;
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
