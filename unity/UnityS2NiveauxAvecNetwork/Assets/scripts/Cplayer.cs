using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplayer : MonoBehaviour
{
    public bool CanGo;
    //public bool Menu;
    int nbrSaut;
    Rigidbody rigid;
    public float vitesseX;
    public float vitesseY;
    public float vitesseZ;
    private GameObject safe;
    public bool isMaster;
    public bool playMaster;
    PhotonView view;



    public float multiplicateurV;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        multiplicateurV=400;
        CanGo = true;
        safe = GameObject.Find("safe");
        view = GetComponent<PhotonView>();
    }

    public void resetV()
    {
        vitesseX = 0;
        vitesseY = 0;
        vitesseZ = 0;
    }


    void OnCollisionEnter(Collision chose)
    {
        if (chose.gameObject.tag == ("Wall"))
        {
            CanGo = true;
        }
    }

    void OnTriggerEnter(Collider chose)
    {
        if (chose.gameObject.tag == ("safe"))
        {
            CanGo = true;
            this.resetV();

        }
    }

    /* void OnCollisionExit(Collision chose)
    {
        if (chose.gameObject.tag == ("Wall"))
        {
            CanGo = false;
        }
    }*/

    // Update is called once per frame

    void Update()
    {
        isMaster = PhotonNetwork.isMasterClient;
        //en cas de probleme :
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            CanGo =true;
            
        }
        
        if (CanGo && view.isMine)
        {
            vitesseX = Input.GetAxis("Horizontal");
            vitesseY = Input.GetAxis("Vertical");
            vitesseZ = Input.GetAxis("Depth");
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.LeftControl)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow))
                {
                    CanGo =false;
                } 
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.position = safe.transform.position;
        }
        /*if (Menu)
        {
            vitesseX = 0;
            vitesseY = 0;
            vitesseZ = 0;
            this.transform.position = safe.transform.position;
            
        }*/
        
        
        rigid.velocity = new Vector3(vitesseX * multiplicateurV * Time.deltaTime,
            vitesseY * multiplicateurV * Time.deltaTime,vitesseZ * multiplicateurV * Time.deltaTime);
        
    }
}
