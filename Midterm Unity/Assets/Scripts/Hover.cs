﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    
    public float floatHeight;
    public float hoverHeight;
    public float hoverSpeed;  
    
    private float currentHeight; 
    private float timer;

    void Update()
    {
        //float up and down at float height a distance of hover height at hover speed
        timer += Time.deltaTime*hoverSpeed;
        currentHeight = Mathf.Sin(timer);
        currentHeight = currentHeight * hoverHeight;
        transform.position=new Vector3(transform.position.x,currentHeight+floatHeight,transform.position.z);
    }
}
