using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public bool Face_1;
    public bool down;
    public bool Face_2;
    public bool right;
    public bool Face_3;
    public bool front;
    public bool Face_4;
    public bool back;
    public bool Face_5;
    public bool left;
    public bool Face_6;
    public bool up;
    public static bool CanGo;
    // Start is called before the first frame update
    void Start()
    {
        Face_1=false;
        Face_2=false;
        Face_3=false;
        Face_4=false;
        Face_5=false;
        Face_6=false;
        CanGo =true;
    }
     void OnTriggerEnter(Collider chose)
    {

        if (chose.gameObject.tag == ("Face 1"))
        {
            Face_1=true;
            if(Face_1 && down)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
        if (chose.gameObject.tag == ("Face 2"))
        {
            Face_2=true;
            if(Face_2&&right)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
        if (chose.gameObject.tag == ("Face 3"))
        {
            Face_3=true;
            if(Face_3&&front)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
        if (chose.gameObject.tag == ("Face 4"))
        {
            Face_4=true;
            if(Face_4&&back)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
        if (chose.gameObject.tag == ("Face 5"))
        {
            Face_5=true;
            if(Face_5&&left)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
        if (chose.gameObject.tag == ("Face 6"))
        {
            Face_6=true;
            if(Face_1&&up)
            {
                CanGo =true;
            }
            else CanGo = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&CanGo){up=true; down=false; left=false; right=false; front=false; back=false;}
        if (Input.GetKeyDown(KeyCode.)&&CanGo){up=false; down=true; left=false; right=false; front=false; back=false;}
        if (Input.GetKeyDown(KeyCode.)&&CanGo){up=false; down=false; left=true; right=false; front=false; back=false;}
        if (Input.GetKeyDown(KeyCode.)&&CanGo){up=false; down=false; left=false; right=true; front=false; back=false;}
        if (Input.GetKeyDown(KeyCode.)&&CanGo){up=false; down=false; left=false; right=false; front=true; back=false;}
        if (Input.GetKeyDown(KeyCode.)&&CanGo){up=false; down=false; left=false; right=false; front=false; back=true;}
            
    }
}
