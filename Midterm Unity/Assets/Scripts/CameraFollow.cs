using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    private float xpos;
    private float ypos;
    private float zpos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xpos = Player.transform.position.x;
        ypos = Player.transform.position.y;
        zpos = Player.transform.position.z;
        this.transform.position = new Vector3(xpos,ypos+1,zpos-10f);
    }
}
