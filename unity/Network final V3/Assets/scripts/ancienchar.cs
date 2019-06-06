using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainchara : MonoBehaviour
{
    public bool TCanGo;
    int nbrSaut;
    Rigidbody rigid;
    public float vitesseX;
    public float vitesseY;
    public float vitesseZ;
    
    public float multiplicateurV;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        multiplicateurV=400;
        TCanGo = false;
    }

 
    
     void OnCollisionEnter(Collision chose)
    {
        if (chose.gameObject.tag == ("Wall"))
        {
            TCanGo = true;
        }
    }
    void OnCollisionExit(Collision chose)
    {
        if (chose.gameObject.tag == ("Wall"))
        {
            TCanGo = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        TCanGo = Wall.CanGo;
        if (TCanGo == true)
        {
        vitesseX = Input.GetAxis("Horizontal");
        vitesseY = Input.GetAxis("Vertical");
        vitesseZ = Input.GetAxis("Depth");
        }
        
        
        rigid.velocity = new Vector3(vitesseX * multiplicateurV * Time.deltaTime,vitesseY * multiplicateurV * Time.deltaTime,vitesseZ * multiplicateurV * Time.deltaTime);
        
    }
}
