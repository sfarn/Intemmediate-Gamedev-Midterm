using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    public float turnSpeed;
//    private float timer = 0.0f;
//    float bobbingSpeed = 0.18f;
//    float bobbingAmount = 0.2f;
//    float midpoint = 2.0f;
    public float timer;
    public float hoverHeight;
    public float hoverSpeed;
    private float currentHeight;
  
    void Start()
    {
        
    }
    
    void Update()
    {
        
        CameraTurn();
     
        if (GameManager.Instance.isWalking==true) 
        { 
            HeadBop(); 
        }
    }
    //look up when up arrow's hit and down when down arrow's hit
    void CameraTurn()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(new Vector3( -turnSpeed * Time.deltaTime, 0,0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(new Vector3( turnSpeed * Time.deltaTime, 0,0));
        }
    }

    //head bobs up and down when walking
    void HeadBop()
    {
        timer += Time.deltaTime*hoverSpeed;
        currentHeight = Mathf.Sin(timer);
        currentHeight = currentHeight * hoverHeight;
        transform.position=new Vector3(transform.position.x,currentHeight+6,transform.position.z);
    }
}
