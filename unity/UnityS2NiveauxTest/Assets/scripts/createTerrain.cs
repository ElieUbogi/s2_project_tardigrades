using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ground;
    public GameObject WallNegX;
    public GameObject WallPosX;
    public GameObject WallNegZ;
    public GameObject WallPosZ;
    public GameObject Roof;
    public GameObject Spawn;
    public GameObject Player;
    public GameObject Cameras;
    
    void Start()
    
    {
        float hightWall = 20f;
        ground.transform.localScale = new Vector3(hightWall, 1f, hightWall);
        Vector3 wPosX = new Vector3(
            ground.transform.position.x + ground.transform.localScale.x/2,
            ground.transform.position.y + hightWall/2,
            ground.transform.position.z);
        Vector3 wNegX = new Vector3(
            ground.transform.position.x - ground.transform.localScale.x/2,
            ground.transform.position.y + hightWall/2,
            ground.transform.position.z);
        Vector3 wPosZ = new Vector3(
            ground.transform.position.x,
            ground.transform.position.y + hightWall/2,
            ground.transform.position.z + ground.transform.localScale.z/2);
        Vector3 wNegZ = new Vector3(
            ground.transform.position.x,
            ground.transform.position.y + hightWall/2,
            ground.transform.position.z  - ground.transform.localScale.z/2);
        
        
        Vector3 WScaleX  = new Vector3(1f,hightWall,ground.transform.localScale.z);
        Vector3 WScaleZ = new Vector3(ground.transform.localScale.x,hightWall,1f);
        
        
        WallPosX.transform.position = wPosX;
        WallNegX.transform.position = wNegX;
        WallPosZ.transform.position = wPosZ;
        WallNegZ.transform.position = wNegZ;
        
        WallPosX.transform.localScale = WScaleX;
        WallNegX.transform.localScale = WScaleX;
        WallPosZ.transform.localScale = WScaleZ;
        WallNegZ.transform.localScale = WScaleZ;


        Roof.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y + hightWall,
            ground.transform.position.z);
        Roof.transform.localScale = ground.transform.localScale;
        
        
        Spawn.transform.position = new Vector3(
            ground.transform.position.x + (ground.transform.lossyScale.x/2) - Player.transform.localScale.x - 0.5f,
            ground.transform.position.y+1f,
            ground.transform.position.z + (ground.transform.lossyScale.z)/2 - Player.transform.localScale.z - 0.5f);

        Player.transform.position = Spawn.transform.position;
        
        
        
        //create Cameras
        string s = "";
        Vector3 CamPos = new Vector3();
        Quaternion CamRot = new Quaternion();
        Quaternion Rotx;
        float spaceCam = 0.7f;
        for (int i = 0; i < 8; i++)
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
                CamPos.z = ground.transform.position.z - ground.transform.localScale.z / 2+spaceCam;
                CamRot.y = 45f;
            }
            else
            {
                s += 'N';
                CamPos.z = ground.transform.position.z + ground.transform.localScale.z / 2-spaceCam;
                CamRot.y = 135f;
            }

            if (i % 4 <= 1)
            {
                s += 'E';
                CamPos.x = ground.transform.position.x + ground.transform.localScale.x / 2-spaceCam;
                CamRot.y = CamRot.y *-1f;
            }
            else
            {
                s += 'W';
                CamPos.x = ground.transform.position.x - ground.transform.localScale.x / 2+spaceCam;
                CamRot.y = CamRot.y;
            }

            if (i % 2 == 0)
            {
                s += 'H';
                CamPos.y = ground.transform.position.y + hightWall-spaceCam;
                CamRot.x = 45f;
            }
            else
            {
                s += 'B';
                CamPos.y = ground.transform.position.y + spaceCam;
                CamRot.x = -45f;
            }

            CamRot.z = 0f;
            CamRot.w = 0f;
            GameObject Cam = SearchCam(s);
            Cam.transform.position = CamPos;
            Cam.transform.rotation = new Quaternion(0f,0f,0f,0f);
            Cam.transform.Rotate(CamRot.x,CamRot.y,CamRot.z);
            
            Debug.Log(CamRot.x + " " + CamRot.y + " " + CamRot.z + " : " + Cam.transform.rotation.x + " " + Cam.transform.rotation.y);
            s = "";
        }
        
    }

    public GameObject SearchCam(string name)
    {
       GameObject j = Cameras.transform.Find("Cam"+name).gameObject;
        return j;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
