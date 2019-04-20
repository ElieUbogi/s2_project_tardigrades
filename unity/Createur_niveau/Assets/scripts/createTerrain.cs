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
       // WallPosX.transform.localRotation = new Quaternion();
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
        
        
        
        //create obstacle

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
