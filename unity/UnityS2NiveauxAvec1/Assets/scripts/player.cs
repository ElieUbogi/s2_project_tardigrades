using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool CanGo;
    public bool Menu;
    public bool Breaker;
    int nbrSaut;
    Rigidbody rigid;
    public float vitesseX;
    public float vitesseY;
    public float vitesseZ;
    public GameObject safe;
    public GameObject Player;
    public uint score;
    public GameObject menuPanel;
    public List<GameObject> toRes = new List <GameObject>();


    public float multiplicateurV;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        menuPanel.SetActive(false);
        multiplicateurV=400;
        CanGo = true;
        score = 0;
        Breaker = false;
    }

    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("safe"))
        {
            this.resetV();
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
        if (chose.gameObject.tag == ("Wall"))
        {
            CanGo = true;
        }
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

    public void resetV()
    {
        vitesseX = 0;
        vitesseY = 0;
        vitesseZ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //en cas de probleme :
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            CanGo =true;
        }

        if (CanGo)
        {
            vitesseX = Input.GetAxis("Horizontal");
            vitesseY = Input.GetAxis("Vertical");
            vitesseZ = Input.GetAxis("Depth");
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow))
            {
                CanGo = false;
                score++;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (menuPanel.active)
            {
                menuPanel.SetActive(false);
                score = 0;
            }
            this.transform.position = safe.transform.position;
        }
        
        rigid.velocity = new Vector3(vitesseX * multiplicateurV * Time.deltaTime,vitesseY * multiplicateurV * Time.deltaTime,vitesseZ * multiplicateurV * Time.deltaTime);
    }
        
}